using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject ScoreText;
    public GameObject EnemyPrefab;  //EnemyPrefab
    public float spawnInterval;     //Interval between each spawn
    int score = 0;
    int spawned = 0;
    //spawn area//
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitAndSpawn(spawnInterval));
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private IEnumerator WaitAndSpawn(float waitTime)
    {
        while(true)
        {
            yield return new WaitForSeconds(waitTime);
            Vector3 spawnPosition = new Vector3(Random.Range(minX, maxX), 0.55f, Random.Range(minZ, maxZ));
            spawned++;
            Instantiate(EnemyPrefab, spawnPosition, Quaternion.identity);
        }
        
    }

}
