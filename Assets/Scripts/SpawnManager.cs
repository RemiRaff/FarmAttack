using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float spawnRangeX = 10.0f;
    private float spawnPosZ = 35.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex],
            new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ),
            animalPrefabs[animalIndex].transform.rotation);
    }
}
