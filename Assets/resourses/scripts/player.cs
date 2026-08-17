using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float MoveSpeed;
    private float horizontalInput;
    private Rigidbody2D rb;
    public float jumpForce;

    public Transform groundcheck;
    public LayerMask groundLayer;
    public float groundRadius;
    private bool IsGround;

    private bool CanDash = true;
    private bool IsDashing;
    public float DashingSpeed = 12f;
    public float DashTime = 0.2f;
    public float DashDelay = 1f;
    public TrailRenderer tr;

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsDashing)
        {
            return;
        }
        IsGround = Physics2D.OverlapCircle(groundcheck.position, groundRadius, groundLayer);
        horizontalInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalInput * MoveSpeed, rb.velocity.y);
        if (Input.GetButtonDown("Jump") && IsGround) 
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            AudioManager.instance.playSFX(1);
        }
        if (rb.velocity.x < 0)
        {
            transform.localScale = new Vector3(1f, transform.localScale.y, transform.localScale.z);
        } else if (rb.velocity.x > 0) 
        {
            transform.localScale = new Vector3(-1f, transform.localScale.y, transform.localScale.z);
        }
        anim.SetBool("grounded", IsGround);
        anim.SetFloat("Speed", rb.velocity.x);
        if (Input.GetKeyDown(KeyCode.LeftShift) && CanDash)
        {
            StartCoroutine(Dash());
        }
    }

    IEnumerator Dash()
    {
        CanDash = false;
        IsDashing = true;
        float oggravity = rb.gravityScale;
        rb.gravityScale = 0;
        float dashingdirections = -Mathf.Sign(transform.localScale.x);
        rb.velocity = new Vector2(dashingdirections * DashingSpeed, 0f);
        tr.emitting = true;
        yield return new WaitForSeconds(DashTime);
        tr.emitting = false;
        rb.gravityScale = oggravity;
        IsDashing = false;
        yield return new WaitForSeconds(DashDelay);
        CanDash = true;
    }
}
