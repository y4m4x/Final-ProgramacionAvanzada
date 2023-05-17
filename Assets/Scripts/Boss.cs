using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            Debug.Log("Enemy get shooted");



            Destroy(collision.gameObject);
            Destroy(this.gameObject);

            SceneManager.LoadScene("Victoria");
        }
    }
}
