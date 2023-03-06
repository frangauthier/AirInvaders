using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] float cooldownRate = 2f;
    [SerializeField] float cooldownReduce = 0.05f;

    float spawnRange = 4.5f;
    float nextSpawn = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + cooldownRate;
            SpawnEnemy();
        }

    }

    private void SpawnEnemy()
    {
        Vector3 location = new Vector3(transform.position.x, transform.position.y + Random.Range(-spawnRange, spawnRange), transform.position.z);

        Instantiate(enemy, location, Quaternion.identity);

        cooldownRate -= cooldownReduce;
        cooldownRate = Mathf.Max(0.3f, cooldownRate);
    }
}
