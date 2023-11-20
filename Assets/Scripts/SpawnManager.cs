using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeZ = 4.8f;
    private float spawnPosX = 20;
    private float startDelay= 2.0f;
    private float spawnInterval= 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
   
    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
    
}
