using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public float moveSpeed;

    [SerializeField]
    float _speed = 10f;
    [SerializeField]
    Transform player;
    bool canShoot;


    private void Start()
    {
        canShoot= true;
    }


    private void Update()
    {
        /*if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }*/

        Move(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));


        if (Input.GetKeyDown(KeyCode.C) && canShoot)
        {

            StartCoroutine(SpawnBullet());
           

        }

        //The reason for this is only public variables / functions can be tested by the unity tester.

    }
        public void Move(Vector2 input)
        {
            transform.position += (Vector3)(input * Time.deltaTime * _speed);
        }

    public GameObject Shoot()
    {
        GameObject bullet = Instantiate((GameObject) Resources.Load<GameObject>("Prefabs/Bullet"));
        bullet.transform.position = player.transform.position;
        return bullet;



        /*Instantiate(bullet, player.position, Quaternion.identity);
        bullet.transform.position = player.transform.position;*/
    }

    IEnumerator SpawnBullet()
    {
        Shoot();
        canShoot= false;
        yield return new WaitForSeconds(1.5f);
        canShoot= true;
    }
}
