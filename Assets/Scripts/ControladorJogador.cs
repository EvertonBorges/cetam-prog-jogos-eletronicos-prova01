using UnityEngine;

public class ControladorJogador : MonoBehaviour
{

    public Animator animator;
    public Rigidbody2D rb;
    public LayerMask layerChao;
    public SpriteRenderer spriteRenderer;
    public AudioSource audioSource;
    public float speed;
    public float jumpForce;

    private bool olhandoParaDireita = true;
    private bool noChao = false;

    private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var velocity = rb.linearVelocity;
        velocity.x = horizontal * speed;
        
        animator.SetFloat("yVelocidade", velocity.y);
        animator.SetBool("Correndo", horizontal != 0f);

        noChao = Physics2D.Raycast(transform.position, Vector2.down, 1.2f, layerChao);
        Debug.DrawLine(transform.position, transform.position + new Vector3(0, -1.2f, 0), Color.red, 5f);
        animator.SetBool("NoChao", noChao);
        
        rb.linearVelocity = velocity;

        if (noChao && Input.GetButtonDown("Jump"))
        {
            velocity.y = 4f;
            rb.linearVelocity = velocity;
            rb.AddForce(Vector2.up * jumpForce);
            animator.SetTrigger("Pular");
            audioSource.Play();
        }

        if (olhandoParaDireita && horizontal < 0f)
        {
            spriteRenderer.flipX = true;
            olhandoParaDireita = false;
        }
        else if (!olhandoParaDireita && horizontal > 0f)
        {
            spriteRenderer.flipX = false;
            olhandoParaDireita = true;
        }
    }
    
}
