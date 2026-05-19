using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menuinicial : MonoBehaviour
{
    public void jugar() 
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void salir() 
    {
        Debug.Log("Salir...");
        Application.Quit();
    }

    public void Volver() 
    {
        SceneManager.LoadScene(0);
    }

    public void Tiendita() 
    {
        Debug.Log("No esta disponible aun...");
    }


}
