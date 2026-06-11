using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect : MonoBehaviour
{
    //[SerializeField] float radioBusqueda;
    [SerializeField] LayerMask jugador;
    [SerializeField] Transform transformJugador;
    [SerializeField] float velocidadMovimiento;
    [SerializeField] float DeteccionDistancia = 10f;
    private Vector2 direccion;
    //[SerializeField] float distanciaMaxima;

    public EstadoMovimiento estadoActual;
    void Start()
    {
        //puntoInicial=
    }

    public enum EstadoMovimiento 
    {
        Esperando, Siguiendo, volviendo
    }

    // Update is called once per frame
    void Update()
    {
        switch (estadoActual) 
        {
            case EstadoMovimiento.Esperando:
                EstadoEsperando();
                break;
            case EstadoMovimiento.Siguiendo:
                EstadoSiguiendo();
                break;
        }

    }

    private void EstadoEsperando() 
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -transform.right, DeteccionDistancia, jugador);

        if (hit.collider != null)
        {
            transformJugador = hit.transform;
            direccion = (transformJugador.position - transform.position).normalized;
            estadoActual = EstadoMovimiento.Siguiendo;
            //estadoActual = EstadoMovimiento.Siguiendo;
        }
        //Collider2D jugadorCollider = Physics2D.OverlapCircle(transform.position, radioBusqueda, jugador);

        //if (jugadorCollider)
        //{
        //    transformJugador = jugadorCollider.transform;

        //    direccion = (transformJugador.position - transform.position).normalized;

        //    estadoActual = EstadoMovimiento.Siguiendo;
        //}
    }

    private void EstadoSiguiendo() 
    {
        if (transformJugador == null) 
        {
            estadoActual = EstadoMovimiento.volviendo;
            return;
        }

        transform.position += (Vector3)direccion * velocidadMovimiento * Time.deltaTime;

        //transform.position = Vector2.MoveTowards(transform.position, transformJugador.position, velocidadMovimiento * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + -transform.right * DeteccionDistancia);
        //Gizmos.DrawWireSphere(transform.position, radioBusqueda);
    }
}
