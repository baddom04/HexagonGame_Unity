using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawning : MonoBehaviour
{
    public GameObject hexagonPrefab;
    private float spawnRate = 1f;
    private float spawnTime = 0f;
    [HideInInspector] public bool spawn;
    void Update()
    {
        if (spawn)
        {
            if (Time.time > spawnTime)
            {
                Instantiate(hexagonPrefab);
                spawnTime = Time.time + 1f / spawnRate;
            }
        }
    }
}
