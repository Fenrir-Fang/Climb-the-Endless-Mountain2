using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] float speed = 5;
    private Rigidbody2D rb2D;
    private float move;
    [SerializeField] float jumpforce;
    private bool isGrounded;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] Transform groundCheck;
    [SerializeField] private AudioClip saltoSonido;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] ParticleSystem particulaSalto;
    private int Djump = 2;
    private Animator Animator;
    private float Horizontal;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxisRaw("Horizontal");
        rb2D.velocity = new Vector2(move * speed, rb2D.velocity.y);
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
        Animator.SetFloat("Speed", Mathf.Abs(move));
        //Animator.SetBool("running", Horizontal != 0.0f);
        Animator.SetBool("IsGrounded", isGrounded);


        if (isGrounded) 
        {
            Djump = 2;
            Debug.Log("Salto cargado");
        }


        if (move != 0)
        {
            transform.localScale = new Vector3(Mathf.Sign(move) * Mathf.Abs(transform.localScale.x), transform.localScale.y , transform.localScale.z );
        }

        //if (Input.GetButtonDown("Jump") && isGrounded)
        //{
        //    rb2D.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
        //}

        if (Input.GetKeyDown(KeyCode.Z) && Djump > 0) //(Input.GetButtonDown("Jump") && Djump > 0)//(Input.GetButtonDown("Jump") && isGrounded && Djump > 0)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpforce);
            Djump--;

            audioSource.PlayOneShot(saltoSonido);
            CrearParticulaSalto();
        }
    }

    void CrearParticulaSalto() 
    {
        particulaSalto.Play();
    }

    //public void Respawn()
    //{
    //    transform.position = GameManager.instance.currentCheckpoint;
    //}

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Floor")) 
    //    {
    //        Djump = 2;
    //    }

    //}

    //private void FixedUpdate()
    //{
    //    isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundLayer);
    //}
}
