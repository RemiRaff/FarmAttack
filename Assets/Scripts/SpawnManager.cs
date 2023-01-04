using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // collection of animals for the spawning system
    public GameObject[] animalPrefabs;

    // variables for spawning system, setup the field
    private float spawnRangeX = 10.0f;
    private float spawnPosZ = 35.0f;

    // variables for automatic spawn
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // call on 's' key pressed, can link directly SpawnRandomAnimal to unity event
    public void SpawnAnimal()
    {
        SpawnRandomAnimal();
    }

    private void SpawnRandomAnimal()
    {
        // choose a random index for our array of animals
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        // create the animal with integrated move foward from array
        Instantiate(animalPrefabs[animalIndex],
            new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ),
            animalPrefabs[animalIndex].transform.rotation);
    }
}
