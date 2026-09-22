using System;
using Unity.VisualScripting; 
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 5f;
    private Rigidbody2D rb;
    private bool isGrounded = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");//vai recomhecer os movimentos horizontais 
        rb.linearVelocity = new Vector2(moveHorizontal * speed, rb.linearVelocity.y); 
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector2(0F, 5F), ForceMode2D.Impulse);//vai reconhecer quando o player apertar espaço para asionar o pulo 
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Graund"))
        {
            isGrounded = true; //vai reconhecer quando o jogador encostar em um objeto que temcolisor 

        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Graund"))
        {
            isGrounded = false; //vai reconhecer quando o jogador estiver longe do objeto 
        }
    }

}
