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

    public float speed;

    private Vector2 mov;

    private Button shoot;

    [SerializeField] private Bullet playerBullet;

    private void Awake()
    {
        Input = new PlayerController();
        Rigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        Input.Enable();
        Input.Player.Movimiento.performed += MovementPerformed;
        Input.Player.Movimiento.canceled += MovementCancelled;
        Input.Player.Shoot.performed += ShootPerformed;
    }

    private void OnDisable()
    {
        Input.Disable();
        Input.Player.Movimiento.performed -= MovementPerformed;
        Input.Player.Movimiento.canceled -= MovementCancelled;
        Input.Player.Shoot.performed -= ShootPerformed;
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

    private void ShootPerformed(InputAction.CallbackContext context)
    {
        playerBullet.Shoot();

        Debug.Log("ShootPerformed");
    }
}
