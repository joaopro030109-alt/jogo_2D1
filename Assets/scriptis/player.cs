using Unity.VisualScripting; 
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0F, 5F), ForceMode2D.Impulse);//vai reconhecer quando o player apertar espaço para asionar o pulo 
        }
    }
}
