using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIndex;

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
        Instantiate(animalPrefabs[animalIndex],
            new Vector3(0, 0, 30),
            animalPrefabs[animalIndex].transform.rotation);
    }
}