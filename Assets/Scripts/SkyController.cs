using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyController : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] GameObject leftImage;

    SpriteRenderer sr;
    float imageWidth;
    int count = 0;
    int intervals = 5;

    // Start is called before the first frame update
    void Start()
    {
        sr = leftImage.GetComponent<SpriteRenderer>();
        imageWidth = sr.bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(-speed * Time.deltaTime, 0, 0);
        if (++count % intervals == 0 && !sr.isVisible)
        {
            // move to right
            transform.position = transform.position + new Vector3(imageWidth, 0, 0);
        }
    }


}
