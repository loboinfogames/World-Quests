using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTest : MonoBehaviour
{
    [SerializeField] GameObject goToSpawn; 
    [SerializeField] KeyCode keyToSpawn;
    [SerializeField] int spawnLimit = 4;
    int numOfSpawnedObjects = 0;

    void Update()
    {
        if (Input.GetKeyDown(keyToSpawn))
        {
            bool canSpawn = numOfSpawnedObjects < spawnLimit;
            if (canSpawn)
            {
                Spawn();
            }
        }
    }

    void Spawn()
    {
        numOfSpawnedObjects++;
        var spawnOffset = new Vector3(Random.Range(1f, 3f), Random.Range(1f, 3f), 0f);
        var spawnedGO = GameObject.Instantiate(goToSpawn, transform.position + spawnOffset, Quaternion.identity) as GameObject;
        spawnedGO.GetComponent<SpawnedObjectTest>().RegisterDelegateTo(this);
        

    }

    public void OnSpawnedObjectDeath()
    { 
        numOfSpawnedObjects--;
        Debug.Log(gameObject.name + " delegate was called ");
    }
}