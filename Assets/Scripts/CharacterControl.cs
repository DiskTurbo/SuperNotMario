using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterControl : MonoBehaviour
{
    public static CharacterControl PlayerInstance { get; private set; }

    Rigidbody rb;
    public float walkspeed, runspeed, jumpforce;
    public bool grounded;
    bool isPaused;

    private void Start()
    {
        if (PlayerInstance != null && PlayerInstance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            PlayerInstance = this;
        }
        rb = GetComponent<Rigidbody>();
        isPaused = false;
    }
    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
        if(transform.position.y <= -3f)
        {
            PlayerDeath();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (isPaused == true)
                Resume();
            else
                Pause();
        }
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

    void PlayerDeath()
    {
        SceneManager.LoadScene(1);
    }

    void Pause()
    {
        Time.timeScale = 0;
    }

    void Resume()
    {
        Time.timeScale = 1;
    }

}
