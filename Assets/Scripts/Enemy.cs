using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public float walkspeed;
    Rigidbody rb;
    bool activated;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if(activated == true)
            rb.AddForce(walkspeed, 0f, 0f);
    }
    public void Die()
    {
        Destroy(this);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(collision.gameObject);
            Invoke("PlayerDeath", 5f);
        }
        walkspeed = -walkspeed;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "ActivationArea")
        {
            activated = true;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "ActivationArea")
        {
            activated = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "ActivationArea")
        {
            activated = false;
        }
    }
    void PlayerDeath()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
