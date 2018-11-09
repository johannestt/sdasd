using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed = 6f;
    public float jumpSpeed = 12f;

    public GroundChecker gCheck;

    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {


        rbody = GetComponent<Rigidbody2D>();

    }

    // Update is sdasdasfasdadasdsdsdsd
    void Update()
    {
        rbody.velocity = new Vector2(
            Input.GetAxis("Horizontal") * moveSpeed,
            rbody.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            if(gCheck.isGrounded == true)
            rbody.velocity = new Vector2(rbody.velocity.x, jumpSpeed);
        }
    }
}
