﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    private float delay = 2;
    private float currentTime = 0;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        currentTime += Time.deltaTime;
        if(currentTime >= delay)
        {
            SpawnObstacle();
            currentTime = 0;
            delay = Random.Range(1, 2.5f);
        }
    }
    
    void SpawnObstacle()
    {
        int index = Mathf.FloorToInt(Random.Range(0, 3.5f));
        Instantiate(obstaclePrefabs[index], spawnPos, obstaclePrefabs[index].transform.rotation);
    }
}
