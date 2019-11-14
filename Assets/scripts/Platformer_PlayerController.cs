using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platformer_PlayerController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;

    [SerializeField]
    private float jumpHeight;

    private Rigidbody2D playerRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Jump
        if (Input.GetKeyDown(KeyCode.Space))
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
