using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platformer_PlayerController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;

    [SerializeField]
    private float jumpHeight;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;


    private Rigidbody2D playerRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }
    // Update is called once per frame
    void Update()
    {
        //Jump
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x, jumpHeight);
        }
        //run right
        if (Input.GetKey(KeyCode.D))
        {
            playerRigidBody.velocity = new Vector2(moveSpeed, playerRigidBody.velocity.y);
      
        }
        //Run left
        if (Input.GetKey(KeyCode.A))
        {
            playerRigidBody.velocity = new Vector2(-1 * moveSpeed, playerRigidBody.velocity.y);

        }
    }


}
