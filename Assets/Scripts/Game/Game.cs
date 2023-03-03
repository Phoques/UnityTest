using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Game : MonoBehaviour
{

    public Player player;
    public bool justSpawned;


    private void Start()
    {
        justSpawned = true;
        //SpawnAsteroid();
    }
    public GameObject SpawnAsteroid()
    {
        GameObject asteroid = Instantiate((GameObject) Resources.Load<GameObject>("Prefabs/Asteroid"));
        asteroid.transform.position = new Vector3(Random.Range(-8f, 8f), 7, 0);
        return asteroid;
    }

    private void Update()
    {
        if (justSpawned)
        {
        StartCoroutine(SpawnRestricter());    

        }
    }

    IEnumerator SpawnRestricter()
    {
        SpawnAsteroid();
        justSpawned= false;
        yield return new WaitForSeconds(3);
        justSpawned = true;
        
    }

}
