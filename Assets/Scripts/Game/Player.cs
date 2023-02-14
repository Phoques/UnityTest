using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public float moveSpeed;

    [SerializeField]
    float _speed = 10f;
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

    }

    //The reason for this is only public variables / functions can be tested by the unity tester.
    public void Move(Vector2 input)
    {
        transform.position += (Vector3)(input * Time.deltaTime * _speed);
    }
}
