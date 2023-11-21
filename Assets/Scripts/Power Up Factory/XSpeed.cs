using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XSpeed : PowerUp, PowerUpInterface
{
    public override string PowerUpName => "XSpeedPowerUp";
    public float newSpeed = 6f;

    private void Start()
    {
        gameObject.SetActive(true);
    }
    public void Action(GameObject player)
    {
        Debug.Log("Speed has increased");
        player.GetComponent<Player>().XSpeed(newSpeed);
        gameObject.SetActive(false);
    }
}
