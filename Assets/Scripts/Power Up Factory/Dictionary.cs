using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Experimental.GraphView;

public class Dictionary : MonoBehaviour
{
    [SerializeField] private PowerUp[] PowerUp;
    private Dictionary<string, PowerUp> PowerUpDictionary;

    private void Awake()
    {
        PowerUpDictionary = new Dictionary<string, PowerUp>();

        foreach (var PuP in PowerUp)
        {
            PowerUpDictionary.Add(PuP.PowerUpName, PuP);
        }
    }

    public PowerUp PowerUpSpawn(string name, Transform PowerUpTransform)
    {
        if (PowerUpDictionary.TryGetValue(name, out PowerUp powerUpPrefab))
        {
            PowerUp powerUpInstance = Instantiate(powerUpPrefab, PowerUpTransform.position, Quaternion.identity);
            return powerUpInstance;
        }
        else
        {
            Debug.LogWarning($"El PowerUp '{PowerUpDictionary}' no existe en la base de datos de PowerUps.");
            return null;
        }
    }
}
