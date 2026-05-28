using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Altura : MonoBehaviour
{
    public TMP_Text TextAltura;
    public Transform player;
    void Start()
    {
        
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
            TextAltura.text = "Altura: " + player.position.y.ToString("F2");
        
    }
}
