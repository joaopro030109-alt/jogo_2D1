using UnityEngine;

public class dash : MonoBehaviour
{
    // PUBLIC
    public float dashForce = 90f;
    public float dashDuration = 0.29f;
    public float dashCooldown = 1f;

    // VARIÁVEIS
    private Rigidbody2D rb;
    private bool canDash = true;
    private bool isDashing = false;
    private float lastDirection = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
       rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        // A/D e setas
        float direction = Input.GetAxisRaw("Horizontal");

        // Guarda a última direção
        if (direction != 0)
        {
            lastDirection = direction;
        }

        // SHIFT faz o dash
        if (Input.GetKeyDown(KeyCode.LeftShift) && canDash)
        {
            rb.linearVelocity = new Vector2(
                lastDirection * dashForce,
                0
            );

            canDash = false;

            Invoke("LiberarDash", dashCooldown);
        }
    }
    void LiberarDash()
    {
        canDash = true;
    }
}
