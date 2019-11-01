using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;
    public float minWait = 3.0f;
    public float maxWait = 5.0f;

    //private float startDelay = 2.0f;
    // private float spawnInterval = 4.0f;

    // Start is called before the first frame update

    void Start()
    {
        // Reminder: Maybe use an for loop as you know how many times you are spawning by. 

        float timer = Random.Range(minWait, maxWait);
        Invoke("SpawnRandomBall", timer);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        // Generate random ball index and random spawn position

        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int animalIndex = Random.Range(0, ballPrefabs.Length);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[animalIndex], spawnPos, ballPrefabs[animalIndex].transform.rotation);
        float timer = Random.Range(minWait, maxWait);
        Invoke("SpawnRandomBall", timer);
    }

}
