using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    public float speed;

    public int damage;

    public void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    public void Update()
    {
        Vector2 target = player.transform.position - transform.position;
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            Debug.Log("Enemy get damaged");
            gameObject.SetActive(false);
        }
    }
}
