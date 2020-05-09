using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicGun : MonoBehaviour
{
    public bool shooting = false;
    public GameObject bullet;
    public PlayerStats stats;
    private float lastShot = 0.0f;
    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && (Time.time > 1/stats.fireRate + lastShot)) {
            Shoot();
        }
    }

    void Shoot()
    {
        Rigidbody2D newBullet = Instantiate(bullet, transform.position, transform.rotation).GetComponent<Rigidbody2D>();
        newBullet.velocity = (Vector2)(transform.up * stats.bulletSpeed);
        lastShot = Time.time;
    }
}
