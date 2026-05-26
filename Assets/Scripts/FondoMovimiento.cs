using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoMovimiento : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField]  Vector2 velocidadMovimiento = new Vector2(0.1f, 0.1f);

    private Material material;

    private Vector3 UltimaPosicion;

    
    private void Awake()
    {
        
        material = GetComponent<SpriteRenderer>().material;
    }

    private void Start()
    {
        UltimaPosicion = player.position;
    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 movimientoPlayer = player.position - UltimaPosicion;

        Vector2 offset = new Vector2(movimientoPlayer.x, movimientoPlayer.y);

        material.mainTextureOffset += offset * velocidadMovimiento;

        UltimaPosicion = player.position;
    }
}
