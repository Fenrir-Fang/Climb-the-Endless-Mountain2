using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Destroyed : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;

    [SerializeField] Pausa GameOverManager;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Floor")) 
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Obstaculo"))
        {
            Destroy(other.gameObject);
        }

        if (other.CompareTag("Player"))
        {
            GameOverManager.GameOver();
            //restartlevel();
        }

        //if (other.gameObject.CompareTag("Player"))
        //{
        //    GameOverManager.GameOver();
        //    //restartlevel();
        //}

        //if (other.CompareTag("Player"))
        //{
        //    Vidas life = other.GetComponent<Vidas>();

        //    if (life != null)
        //    {
        //        life.PerderVidas();
        //    }
        //}
    }

    //void restartlevel() 
    //{

    //    Scene escenaActual = SceneManager.GetActiveScene();
    //    SceneManager.LoadScene(escenaActual.name);
    //}
}
