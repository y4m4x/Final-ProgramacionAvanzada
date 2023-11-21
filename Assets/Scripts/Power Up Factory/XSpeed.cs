using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XSpeed : PowerUp, PowerUpInterface
{
    public override string PowerUpName => "XSpeedPowerUp";
    public float newSpeed = 6f;
    public void Action(GameObject player)
    {
        Debug.Log("Speed has increased");
        player.GetComponent<Player>().XSpeed(newSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
        }
    }

    public override void Activate()
    {
        throw new System.NotImplementedException();
    }
}
