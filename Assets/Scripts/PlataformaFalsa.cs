using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaFalsa : MonoBehaviour
{
    [SerializeField] float TiempoCaida;

    private Rigidbody2D rb2D;

    private bool caida = false;
    // Start is called before the first frame update
    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
   private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            StartCoroutine(Caida(other));
        }
    }

    private IEnumerator Caida(Collision2D other)
    {
        yield return new WaitForSeconds(TiempoCaida);
        caida = true;
        Physics2D.IgnoreCollision(transform.GetComponent<Collider2D>(), other.transform.GetComponent<Collider2D>());
        rb2D.constraints = RigidbodyConstraints2D.None;
        rb2D.AddForce(new Vector2(0.1f, 0));
    }
}
