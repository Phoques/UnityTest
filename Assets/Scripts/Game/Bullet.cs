using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    public GameObject bullet;
    public float bulletSpeed = 10f;

    private void Update()
    {
        
            
        MoveBullet();
        
    }

    
   private void MoveBullet()
    {
        bullet.transform.Translate(Vector3.up * Time.deltaTime, Space.World);
    }

}
