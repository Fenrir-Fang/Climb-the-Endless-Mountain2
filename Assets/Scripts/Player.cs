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

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
        move = Input.GetAxisRaw("Horizontal");
        rb2D.velocity = new Vector2(move * speed, rb2D.velocity.y);

        if (move != 0)
        {
            transform.localScale = new Vector3(Mathf.Sign(move), 1, 1);
        }

        //if (Input.GetButtonDown("Jump") && isGrounded)
        //{
        //    rb2D.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
        //}

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpforce);
        }


    }

    //private void FixedUpdate()
    //{
    //    isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundLayer);
    //}
}
