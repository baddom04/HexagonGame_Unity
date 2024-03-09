using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject hexagonPrefab;
    private float spawnRate = 1f;
    private float spawnTime = 0f;
    void Update()
    {
        if(Time.time > spawnTime){
            Instantiate(hexagonPrefab);
            spawnTime = Time.time + 1f / spawnRate;
        }
    }
}
