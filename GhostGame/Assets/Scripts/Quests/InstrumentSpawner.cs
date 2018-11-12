using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstrumentSpawner : MonoBehaviour
{

    public Transform spawnLocation;
    public Transform ghostLocationWhenSpawning;
    public GameObject spawnPrefab;
    public GameObject whatToSpawn;

    private void Start()
    {
        //spawn();
    }
    private void Update()
    {

    }

    public void spawn()
    {
        whatToSpawn = Instantiate(spawnPrefab, spawnLocation.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    // spawn instrument when ghost enters trigger
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ghost"))
        {
            spawn();
        }

    }
}
