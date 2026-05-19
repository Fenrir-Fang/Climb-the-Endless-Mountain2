using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Pausa : MonoBehaviour
{
    [SerializeField] GameObject Pausebutton;
    [SerializeField] GameObject PauseMenu;
    [SerializeField] GameObject Restartbutton;
    [SerializeField] GameObject GameOverMenu;
    [SerializeField] GameObject RespawnButton;
    [SerializeField] Transform player;
    [SerializeField] int Continues = 3;
    public TMP_Text TextGanchos;

    void Start()
    {
        ActualizarTextoContinues();
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
        Pausebutton.SetActive (false);
        PauseMenu.SetActive(true);

    }

    public void ResumeGame() 
    {
        Time.timeScale = 1;
        Pausebutton.SetActive(true);
        PauseMenu.SetActive(false);
    }

    public void RestartGame() 
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //GameOverMenu.SetActive(true);
    }

    public void GameOver() 
    {
        Time.timeScale = 0;

        Pausebutton.SetActive(false);

        GameOverMenu.SetActive(true);
    }

    public void RespawnCheckPoint() 
    {
        if (Continues <= 0)
            return;
        Continues --;

        ActualizarTextoContinues();

        Time.timeScale = 1;

        player.position = GameManager.instance.currentCheckpoint;

        Rigidbody2D rb = player.GetComponent<Rigidbody2D>();

        if (rb != null) 
        {
            rb.velocity = Vector2.zero;
        }

        Pausebutton.SetActive(true);

        GameOverMenu.SetActive(false);

        Debug.Log("Continues Restantes: " + Continues);

        if (Continues <= 0) 
        {
            RespawnButton.SetActive(false);
        }


    }
    void ActualizarTextoContinues()
    {
        TextGanchos.text = ":" + Continues;
    }

    public void Volver()
    {
        
        SceneManager.LoadScene(0);
    }
}
