using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestScript
{
    // Use the Assert class to test conditions
    //Is 0 less than 1. (Pass)
    //Assert.Less(0,1);
    //is 5 greater than 1 (Pass)
    //Assert.Greater(5,1);
    // A Test behaves as an ordinary method
    /*[Test]
    public void TestScriptSimplePasses()
    {

    }*/

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    Game game;

    [SetUp]
    public void SetUp()
    {
        GameObject gameGameObject = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Game"));
        game = gameGameObject.GetComponent<Game>();
    }

    [TearDown]

    public void TearDown()
    {
        Object.Destroy(game.gameObject);
    }

    [UnityTest]
    public IEnumerator DestroyAsteroid()
    {
        GameObject asteroid = game.SpawnAsteroid();
        GameObject bullet = MonoBehaviour.Instantiate((GameObject)Resources.Load("Prefabs/Bullet"));

        bullet.transform.position = asteroid.transform.position;

        yield return new WaitForSeconds(3f);

        //This needs to be done because C# null is different to Unity Null
        UnityEngine.Assertions.Assert.IsNull(asteroid);
    }


    [UnityTest]
    public IEnumerator PlayerMovesRight()
    {
        GameObject playerObject = game.player.gameObject;
        Player player = playerObject.GetComponent<Player>();

        Vector2 playerPosition = player.transform.position;
        player.Move(new Vector2(1,0));
        yield return null;
        Assert.Greater(player.transform.position.x, playerPosition.x);
    }


    [UnityTest]
    public IEnumerator AsteroidDownFall()
    {
       
        GameObject asteroid = game.SpawnAsteroid();


        Vector2 asteroidPosition = asteroid.transform.position;

        yield return new WaitForSeconds(3f);

        //This is asking if the asteroids current y position, is less than
        Assert.Less(asteroid.transform.position.y, asteroidPosition.y);

        
    }
}
