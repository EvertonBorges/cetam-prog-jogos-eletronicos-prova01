using UnityEngine;

public class ControladorJogador : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb;
    public LayerMask layerChao;
    public SpriteRenderer spriteRenderer;
    public AudioSource audioSource;

    public float speed = 4f;
    public float jumpForce = 10f;

    private bool olhandoParaDireita = true;
    private bool noChao = false;

    private void Awake()
    {
        // Procura automaticamente um AudioSource no Player
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        Vector2 velocity = rb.linearVelocity;
        velocity.x = horizontal * speed;
        rb.linearVelocity = velocity;

        animator.SetFloat("yVelocidade", rb.linearVelocity.y);
        animator.SetBool("Correndo", horizontal != 0f);

        noChao = Physics2D.Raycast(
            transform.position,
            Vector2.down,
            1.2f,
            layerChao
        );

        Debug.DrawLine(
            transform.position,
            transform.position + new Vector3(0, -1.2f, 0),
            Color.red
        );

        animator.SetBool("NoChao", noChao);

        if (noChao && Input.GetButtonDown("Jump"))
        {
            velocity = rb.linearVelocity;
            velocity.y = 0f;
            rb.linearVelocity = velocity;

            rb.AddForce(Vector2.up * jumpForce);

            animator.SetTrigger("Pular");

            // Só toca som se existir AudioSource
            if (audioSource != null)
            {
                audioSource.Play();
            }
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