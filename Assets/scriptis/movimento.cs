using UnityEngine;

public class movimento : MonoBehaviour
{
    public float dashForce = 15f;
    public float dashDuration = 0.15f;
    public float dashCooldown = 1f;

    private bool canDash = true;
    private bool isDashing = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        rb.linearVelocity = new Vector2(
            moveHorizontal * speed,
            rb.linearVelocity.y
        );

        // PULO
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector2(0F, 6F), ForceMode2D.Impulse);
        }

        // DASH
        if (Input.GetKeyDown(KeyCode.LeftShift) && canDash && !isDashing)
        {
            StartCoroutine(Dash());
        }
        private System.Collections.IEnumerator Dash()
    {
        canDash = false;
        isDashing = true;

        // Descobre para qual lado o jogador está andando
        float direction = Input.GetAxisRaw("Horizontal");

        // Se não estiver apertando nenhuma direção,
        // o dash vai para a direita
        if (direction == 0)
        {
            direction = 1;
        }

        // Guarda a gravidade original
        float gravity = rb.gravityScale;

        // Remove a gravidade durante o dash
        rb.gravityScale = 0;

        // Faz o jogador avançar
        rb.linearVelocity = new Vector2(direction * dashForce, 0);

        // Duração do dash
        yield return new WaitForSeconds(dashDuration);

        // Para o dash
        rb.linearVelocity = Vector2.zero;

        // Recupera a gravidade
        rb.gravityScale = gravity;

        isDashing = false;

        // Tempo para poder usar novamente
        yield return new WaitForSeconds(dashCooldown);

        canDash = true;
    }
}

    // Update is called once per frame
    void Update()
    {

    }
   

}
