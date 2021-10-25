using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundCheck : MonoBehaviour
{
    CharacterControl charControl;

    void Awake()
    {
        charControl = GetComponentInParent<CharacterControl>(); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == charControl.gameObject)
        {
            return;
        }
        else if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject, 3f);
            Destroy(other);
            charControl.GetComponent<Rigidbody>().AddForce(0f, 450f, 0f);
        }
        charControl.SetGroundedState(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == charControl.gameObject)
        {
            return;
        }
        charControl.SetGroundedState(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == charControl.gameObject)
        {
            return;
        }
        else if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject, 3f);
            Destroy(other);
        }
        charControl.SetGroundedState(true);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == charControl.gameObject)
        {
            return;
        }
        else if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<Enemy>().Die();
        }
        charControl.SetGroundedState(true);
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject == charControl.gameObject)
        {
            return;
        }
        else if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<Enemy>().Die();
        }
        charControl.SetGroundedState(true);
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject == charControl.gameObject)
        {
            return;
        }
        else if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<Enemy>().Die();
        }
        charControl.SetGroundedState(true);
    }
}
