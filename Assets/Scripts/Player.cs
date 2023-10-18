using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private PlayerController Input;

    private Rigidbody2D Rigidbody;

    public GameObject GameManager;
    
    public GameObject GameOver;
    
    public Text LivesUIText;

    const int MaxLives = 3;
    int Lives;

    public float speed;

    private Vector2 mov;

    private void Awake()
    {
        Input = new PlayerController();
        Rigidbody = GetComponent<Rigidbody2D>();
    }


    public void Init()
    {
        Lives = MaxLives;

        LivesUIText.text = Lives.ToString();

        gameObject.SetActive (true);
    }

    private void OnEnable()
    {
        Input.Enable();
        Input.Player.Movimiento.performed += MovementPerformed;
        Input.Player.Movimiento.canceled += MovementCancelled;
    }

    private void OnDisable()
    {
        Input.Disable();
        Input.Player.Movimiento.performed -= MovementPerformed;
        Input.Player.Movimiento.canceled -= MovementCancelled;
    }

    private void FixedUpdate()
    {
        Rigidbody.velocity = mov * speed;
    }

    private void MovementPerformed(InputAction.CallbackContext context)
    {
        mov = context.ReadValue<Vector2>();
    }

    private void MovementCancelled(InputAction.CallbackContext context)
    {
        mov = Vector2.zero;
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            Lives = MaxLives;
        }
    }
}
