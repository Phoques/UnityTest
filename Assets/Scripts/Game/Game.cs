using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

    public Player player;



    private void Start()
    {
        SpawnAsteroid();
    }
    public GameObject SpawnAsteroid()
    {
        GameObject asteroid = Instantiate((GameObject) Resources.Load<GameObject>("Prefabs/Asteroid"));
        asteroid.transform.position = new Vector2 (0, 2);
        return asteroid;
    }

}
