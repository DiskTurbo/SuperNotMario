using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    bool isHit;
    Text moneycount;
    public static int count;
    // Start is called before the first frame update
    void Start()
    {
        moneycount = GameObject.FindGameObjectWithTag("Money Count").GetComponent<Text>();
        isHit = false;
        count = 0;
        moneycount.text = "Money: " + count;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Head" && isHit == false && Build.buildMode == false)
        {
            isHit = true;
            count++;
            moneycount.text = "Money: " + count;
        }
    }
}
