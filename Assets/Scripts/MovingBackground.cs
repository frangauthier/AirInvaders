using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackground : MonoBehaviour
{
    [SerializeField] float speed;

    private float startPos;
    float imageWidth;

    // Start is called before the first frame update
    void Start()
    {
        imageWidth = GetComponentInChildren<SpriteRenderer>().bounds.size.x;
        startPos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(-speed * Time.deltaTime, 0, 0);

        if(transform.position.x < startPos - imageWidth)
        {
            // move to right
            transform.position = transform.position + new Vector3(imageWidth, 0, 0);
        }
    }
}
