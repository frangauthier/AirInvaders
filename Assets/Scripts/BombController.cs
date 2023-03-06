using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    [SerializeField] float lifetime = 3f;
    [SerializeField] GameObject explosionPrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExplosionCountdown());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ExplosionCountdown()
    {
        yield return new WaitForSeconds(lifetime);
        Explode();
    }

    private void Explode()
    {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        KillAllEnemies();
        Destroy(gameObject);
    }

    private void KillAllEnemies()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        Debug.Log("Enemies count: "+ enemies.Length);
        foreach(GameObject enemy in enemies)
        {
            EnemyMovement em = enemy.gameObject.GetComponent<EnemyMovement>();
            if(em != null)
            {
                em.TriggerDeath();
            }
        }
    }
}
