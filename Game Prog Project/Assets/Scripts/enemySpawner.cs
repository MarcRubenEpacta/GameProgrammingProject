using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    private float nextSpawntime;

    [SerializeField]
    private GameObject enemyAIPath;
    [SerializeField]
    private float spawnDelay = 10;
    
    // Update is called once per frame
    void Update()
    {
        if (ShouldSpawn()) {
            Spawn();
        }
    }

    private void Spawn() {
        nextSpawntime = Time.time + spawnDelay;
        Instantiate(enemyAIPath, transform.position, Quaternion.identity);
    }

    private bool ShouldSpawn() {
        return Time.time >= nextSpawntime;
    }
}
