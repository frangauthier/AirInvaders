using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] GameObject bombPrefab;
    [SerializeField] GameObject gunTip;
    [SerializeField] float bulletSpeed = 10f;
    [SerializeField] float shootingCooldown = 0.5f;

    float nextShootTime = 0f;
    float bombSpeed;

    // Start is called before the first frame update
    void Start()
    {
        bombSpeed = bulletSpeed / 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Fire1") != 0 && Time.time > nextShootTime)
        {
            // Shoot
            nextShootTime = Time.time + shootingCooldown;

            GameObject newBullet = Instantiate(bulletPrefab, gunTip.transform.position, Quaternion.identity);

            Rigidbody2D bulletRb = newBullet.gameObject.GetComponent<Rigidbody2D>();
            bulletRb.velocity = Vector3.right * bulletSpeed;
        }
        else if(Input.GetAxis("Fire2") != 0 && Time.time > nextShootTime)
        {
            // Shoot
            nextShootTime = Time.time + shootingCooldown;

            GameObject newBomb = Instantiate(bombPrefab, gunTip.transform.position, Quaternion.identity);

            Rigidbody2D bombRb = newBomb.gameObject.GetComponent<Rigidbody2D>();
            bombRb.velocity = Vector3.right * bombSpeed;
        }
    }
}
