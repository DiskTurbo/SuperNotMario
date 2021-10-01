using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    bool isHit;
    [SerializeField] Text moneycount;
    static int count;
    // Start is called before the first frame update
    void Start()
    {
        isHit = false;
        count = 0;
        moneycount.text = "Money: " + count;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Head" && isHit == false)
        {
            isHit = true;
            count++;
            moneycount.text = "Money: " + count;
        }
    }
}
