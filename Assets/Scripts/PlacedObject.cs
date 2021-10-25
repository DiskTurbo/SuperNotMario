using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacedObject : MonoBehaviour
{
    private Grid g;
    ActivationArea activationArea;


    private void Awake()
    {
        g = FindObjectOfType<Grid>();
        activationArea = FindObjectOfType<ActivationArea>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(1) && g.isActiveAndEnabled)
        {
            activationArea.GetComponent<Collider>().enabled = false;
            RaycastHit hitInfo;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hitInfo))
            {
                if(hitInfo.transform.tag == "Object" || hitInfo.transform.tag == "Enemy")
                {
                    Destroy(hitInfo.transform.gameObject);
                }
            }
            activationArea.GetComponent<Collider>().enabled = true;
        }
    }
}
