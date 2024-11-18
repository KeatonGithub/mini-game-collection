using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingSpawner : MonoBehaviour
{
    public GameObject ringPrefab;
    public float spawnInterval = 2f;
    public Vector2 spawnRangeX = new Vector2(-8f, 8f);
    public Vector2 spawnRangeY = new Vector2(-4f, 4f);

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnRing();
            timer = 0f;
        }
    }

    void SpawnRing()
    {

        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        float randomY = Random.Range(spawnRangeY.x, spawnRangeY.y);
        Vector3 spawnPosition = new Vector3(randomX, randomY, 0f);

        Instantiate(ringPrefab, spawnPosition, Quaternion.identity);
    }
}