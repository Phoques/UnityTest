using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    public GameObject bullet;
    public GameObject player;
    private Rigidbody2D rb;
    public float bulletSpeed = 10f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            GameObject bullet = Instantiate((GameObject)Resources.Load<GameObject>("Prefabs/Bullet"));
            bullet.transform.position = player.transform.position;
            //Not sure how to make bullet move.

        }

        
    }


   

}
