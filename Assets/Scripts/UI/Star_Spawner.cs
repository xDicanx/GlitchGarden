using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_Spawner : MonoBehaviour
{
    //the variables manipulate how much time we have to wait
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    [SerializeField] Star starPrefab;
    private Vector2 spawnPos;
    private bool spawn = true;


    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker()
    {
        Instantiate(starPrefab, transform.position, transform.rotation);
    }

}
