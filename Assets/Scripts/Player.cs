using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    
    public GameObject GameManager;
    
    public GameObject GameOver;
    
    public Text LivesUIText;

    const int MaxLives = 3;
    int Lives;

    public float speed;

    public void Init()
    {
        Lives = MaxLives;

        LivesUIText.text = Lives.ToString();

        gameObject.SetActive (true);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Lives--;
        LivesUIText.text = Lives.ToString();

        if (Lives == 0)
        {
            SceneManager.LoadScene("Derrota");

            gameObject.SetActive(false);
        }
    }
}
