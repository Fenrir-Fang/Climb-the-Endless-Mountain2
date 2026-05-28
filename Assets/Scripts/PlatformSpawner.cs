using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] GameObject ObjPrefab;
    [SerializeField] float minX = -8f;
    [SerializeField] float MasX = 8f;
    [SerializeField] float time = 1f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", 0f, time);
    }

    void SpawnObject()
    {
        float randomX = Random.Range(minX, MasX);
        Vector2 spawnPosition = new Vector2(randomX, transform.position.y);

        Instantiate(ObjPrefab, spawnPosition, Quaternion.identity);
    }
    void Update()
    {
        
    }
}
