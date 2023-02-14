using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidFall : MonoBehaviour
{

    public GameObject asteroid;

    private void Start()
    {
        
    }
    private void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision) // DO NOT USE 'Is Trigger' ONE object must have a Rigid Body.
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Debug.Log("Hit Asteroid");
            Destroy(gameObject);
        }
    }

}
