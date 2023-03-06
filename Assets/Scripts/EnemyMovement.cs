using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public static float enemySpeed = 1f;

    Rigidbody2D rb;
    Animator anim;
    bool isDead = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!isDead)
        {
            rb.velocity = new Vector3(-EnemyMovement.enemySpeed, 0, 0);
        }else
        {
            rb.velocity = Vector3.zero;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bullet" && !isDead)
        {
            TriggerDeath();
            Destroy(collision.gameObject);
        }
    }

    public void TriggerDeath()
    {
        isDead = true;
        EndGame.killCount++;
        EnemyMovement.enemySpeed += 0.05f;
        anim.SetTrigger("Death");
        Destroy(gameObject, 2);
    }
}
