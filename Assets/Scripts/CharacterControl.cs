using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    Rigidbody rb;
    public float walkspeed, runspeed, jumpforce;
    public bool grounded;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Input.GetKey(KeyCode.LeftShift) ? runspeed : walkspeed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Input.GetKey(KeyCode.LeftShift) ? -runspeed : -walkspeed, 0f, 0f);
        }
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            rb.AddForce(transform.up * jumpforce);
        }
    }

    public void SetGroundedState(bool _grounded)
    {
        grounded = _grounded;
    }

}
