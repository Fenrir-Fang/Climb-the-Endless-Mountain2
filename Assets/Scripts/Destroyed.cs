using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroyed : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Floor")) 
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Player")) 
        {
            restartlevel();
        }
    }

    void restartlevel() 
    {
        Scene escenaActual = SceneManager.GetActiveScene();
        SceneManager.LoadScene(escenaActual.name);
    }
}
