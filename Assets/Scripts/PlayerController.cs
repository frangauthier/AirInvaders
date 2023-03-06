using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 0.5f;

    Rigidbody2D rb;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            // Move up
            // transform.position += new Vector3(0, speed, 0);
            rb.velocity = new Vector3(0, speed, 0);

        }
        else if (Input.GetAxisRaw("Vertical") < 0)
        {
            //transform.position += new Vector3(0, -speed, 0);
            rb.velocity = new Vector3(0, -speed, 0);
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
        
        anim.SetFloat("VerticalSpeed", rb.velocity.y);
    }
}
