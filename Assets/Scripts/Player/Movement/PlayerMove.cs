using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMove : MonoBehaviour
{

    public Rigidbody rb;

    [Header("Walk Variables")]
    public float moveSpeed;
    private float inputX;

    [Header("Jump Variables")]
    public float jumpForce;
    public int availableJumps;
    public int maxJumps = 1;
    public bool canJump;

    [Header("Ground Variables")]
    public Transform groundCheck;
    public float checkGroundRadius;
    public LayerMask whatIsGround;
    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        availableJumps = maxJumps;
    }

    //check if the player is grounded and then reset available jumps to max jumps if true
    public void FixedUpdate()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, checkGroundRadius, whatIsGround);

        if (isGrounded == true)
        {
            availableJumps = maxJumps;
        }
    }

    // Check what direction the player is moving and if the player has any available jumps.
    void Update()
    {
        rb.velocity = new Vector2(inputX * moveSpeed, rb.velocity.y);

        if(availableJumps >= 0)
        {
            canJump = true;
        }

        if (availableJumps <= 0)
        {
            canJump = false;
        }
    }

    //Input action for player move left/right
    public void OnMove(InputAction.CallbackContext context)
    {
        inputX = context.ReadValue<Vector2>().x;
    }

    //Input action for player Jump
    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed && canJump)
        {
            rb.velocity = new Vector2(rb.velocity.y, jumpForce);
            availableJumps -= 1;
        }

    }

}
