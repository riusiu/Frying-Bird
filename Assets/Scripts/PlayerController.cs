using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public float playerVelocity = 10f;
    public float jumpForce = 15f;
    Vector2 playerMovement = Vector2.zero;
    bool asJumped = false;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        //Debug.Log(Time.deltaTime);
    }

    bool IsGrounded()
    {
        if (!asJumped && playerRB.velocity.y == 0)
        {
            asJumped=true;
            return true;
        }
        else return false;
        
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement.x = ( (100f *Time.deltaTime) * playerVelocity * Input.GetAxisRaw("Horizontal"));
        playerRB.AddForce(playerMovement);
        if (Input.GetAxis("Jump")!= 0 && IsGrounded()) {
            asJumped=true;
            playerRB.AddForce(Vector2.up * jumpForce);
        }
    }
}
