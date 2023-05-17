using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour
{
    public int vidas;
    public Image ImagenVidas;
    public Sprite vida6;
    public Sprite vida5;
    public Sprite vida4;
    public Sprite vida3;
    public Sprite vida2;
    public Sprite vida1;
    public Sprite vida0;

    public GameObject Vida;
    public GameObject GameOver;

    // Start is called before the first frame update
    public void Start()
    {
        ImagenVidas = GameObject.FindGameObjectWithTag("vidaImagen").GetComponent<Image>();
    }

    // Update is called once per frame
    public void Update()
    {
        if (vidas <= 0)
        {
            ImagenVidas.sprite = vida0;
            GameOver.SetActive(true);
            Vida.SetActive(false);
        }

        if (vidas == 1)
        {
            ImagenVidas.sprite = vida1;
        }

        if (vidas == 2)
        {
            ImagenVidas.sprite= vida2;
        }

        if (vidas == 3)
        {
            ImagenVidas.sprite = vida3;
        }

        if (vidas == 4)
        {
            ImagenVidas.sprite = vida4;
        }

        if (vidas == 5)
        {
            ImagenVidas.sprite = vida5;
        }

        if (vidas == 6)
        {
            ImagenVidas.sprite = vida6;
        }

        if (vidas > 6)
        {
            vidas = 6;
        }
    }
}
