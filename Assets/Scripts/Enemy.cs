using System.Collections;
using System.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public static float walkspeed;
    Rigidbody rb;
    bool activated;

    [DllImport("INFR3110-F2021")]
    private static extern void SetBossStats(float x, float y, float speed);

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        SetBossStats(this.transform.localScale.x, this.transform.localScale.y, walkspeed);
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
            Destroy(collision.gameObject.GetComponent<CharacterControl>());
            Destroy(collision.gameObject.GetComponent<Rigidbody>());
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
        SceneManager.LoadScene(1);
    }
}
