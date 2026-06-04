using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Altura : MonoBehaviour
{
    public TMP_Text TextAltura;
    public Transform player;
    [SerializeField] TMP_Text TextHighScore;
    private float highScore;
    void Start()
    {
        highScore = PlayerPrefs.GetFloat("HighScore", 0f);

        TextHighScore.text = "Altura Maxima: " + highScore.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        //if (player != null && TextAltura != null)
        //{
        //    TextAltura.text = "Altura: " + player.position.y.ToString("F2");
        //}

        if (player == null || TextAltura == null)
            return;
        
        float alturaActual = player.position.y;

        TextAltura.text = "Altura: " + alturaActual.ToString("F2"); //player.position.y.ToString("F2");

        if (alturaActual > highScore) 
        {
            highScore = alturaActual;

            PlayerPrefs.SetFloat("HighScore", highScore);

            TextHighScore.text = "Altura Maxima: " + highScore.ToString("F2");
        }

        //PlayerPrefs.Save();

        //PlayerPrefs.DeleteAll();

        TextHighScore.text = "Altura Maxima: " + highScore.ToString("F2");


    }
}
