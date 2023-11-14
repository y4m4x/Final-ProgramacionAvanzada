using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victoria : MonoBehaviour
{
    public void VolverMenu()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Cerrar()
    {
        Application.Quit();
    }
}
