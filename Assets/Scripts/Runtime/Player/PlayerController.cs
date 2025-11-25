using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string playerName;
    public Rigidbody2D rb;
    public SpriteRenderer sprite;
    protected float moveInput;
    public bool isGrounded;
    public LayerMask groundLayer;
    public Animator animator;
    void Start()
    {
        Debug.Log("Tes dari Start");
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");

        Debug.Log("Input : " + moveInput);
        
        if (animator != null)
        {
            animator.SetFloat("Speed", Mathf.Abs(moveInput));
            animator.SetBool("IsGrounded", isGrounded);
        }

        Debug.Log("Pergerakan karakter:  " + moveInput);
        
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            // Kode untuk melompat
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 7f);
        }

        if (moveInput > 0)
        {
            sprite.flipX = false;
        }
        else if (moveInput < 0)
        {
            sprite.flipX = true;
        }
    }

    void FixedUpdate()
    {
        // Kode untuk pergerakan fisika
        rb.linearVelocity = new Vector2(moveInput * 5f, rb.linearVelocity.y);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            isGrounded = false;
        }
    }
}
