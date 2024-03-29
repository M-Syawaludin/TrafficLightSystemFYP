﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMangager : MonoBehaviour {
    public GameObject car;                // The enemy prefab to be spawned.
    public float spawnTime = 3f;            // How long between each spawn.
    public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
    public float BufferMin=6f;
    public float BufferMax=20f;
    public float BufferTime;

    // Use this for initialization
    void Start () {
         BufferTime = Random.Range(BufferMin, BufferMax);
      // spawnTime = Random.Range(BufferMin, BufferMax);
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        InvokeRepeating("Spawn", spawnTime, BufferTime);
    }

    void Spawn()
    {

        // Find a random index between zero and one less than the number of spawn points.
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
        Instantiate(car, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);

        
    }

    // Update is called once per frame
    void Update () {
        

    }
}
