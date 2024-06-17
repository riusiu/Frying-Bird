using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    public Transform orientation;
    public float moveSpeed;

    public float groundDrag;

    public float jumpForce;
    public float jumpCooldown;
    public float airMultiplier;
    bool readyToJump = true;

    [Header("GroundCheck")]
    public float playerHeight;
    public LayerMask ground;

    [Header("SpriteControl")]
    public SpriteRenderer playerSprite;

    bool grounded;

    float horizontalInput;

    Rigidbody2D rb;
    Vector2 moveDirection;


    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
    }

    void Update()
    {
        grounded = Physics2D.Raycast(transform.position, Vector2.down, playerHeight * 0.5f + 0.2f, ground);

        PlayerInput();
        SpeedControl();
        FlipSprite();

        if (grounded)
            rb.drag = groundDrag;
        else
            rb.drag = 0;
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }
    private void PlayerInput() {
        horizontalInput = Input.GetAxisRaw("Horizontal");

        if (Input.GetAxis("Jump")!= 0 && readyToJump && grounded) { 
            readyToJump = false;

            Jump();

            Invoke(nameof(ResetJump), jumpCooldown);
        }
    }
    private void MovePlayer()
    {
        moveDirection = orientation.right * horizontalInput;

        if (grounded)
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode2D.Force);

        else if (!grounded)
            rb.AddForce(moveDirection.normalized * moveSpeed * airMultiplier * 10f, ForceMode2D.Force);
    }

    private void SpeedControl() {
        Vector2 flatVet = new Vector2(rb.velocity.x, 0f);

        if (flatVet.magnitude > moveSpeed)
        {
            Vector2 limitedVel = flatVet.normalized * moveSpeed;
            rb.velocity = new Vector2(limitedVel.x, rb.velocity.y);
        }
    }

    private void Jump() { 
        rb.velocity = new Vector2 (rb.velocity.x, 0f);

        rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
    }

    private void ResetJump()
    {
        readyToJump = true;
    }

    private void FlipSprite()
    {
        if (horizontalInput > 0f)
            playerSprite.flipX = false;
        else if (horizontalInput < 0f)
            playerSprite.flipX = true;
    }
}
