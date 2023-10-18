using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnpoint;

    public float shotForce = 1500;
    public float shotRate = 0.5f;

    private float shotRatetime = 0;

    public void Shoot()
    {
        if (Time.time > shotRatetime)
        {
            GameObject newbullet;

            newbullet = Instantiate(bullet, spawnpoint.position, spawnpoint.rotation);

            newbullet.GetComponent<Rigidbody2D>().AddForce(spawnpoint.up * shotForce);

            shotRatetime = Time.time + shotRate;

            Destroy(newbullet, 2);

        }
    }
}
