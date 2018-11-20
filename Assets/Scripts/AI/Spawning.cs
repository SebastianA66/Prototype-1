using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{

    public GameObject spawnee;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    public int spawnLimit = 30;
    public int currentSpawnCount = 0;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }
    public void SpawnObject()
    {
        Instantiate(spawnee, transform.position, transform.rotation);
        currentSpawnCount++;
    }

    private void Update()
    {
        if (currentSpawnCount >= spawnLimit)
        {
            CancelInvoke("SpawnObject");
        }
    }


}
