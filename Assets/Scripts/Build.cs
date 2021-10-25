using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Build : MonoBehaviour
{
    [SerializeField] GameObject g;
    [SerializeField] GameObject objPlace;
    [SerializeField] GameObject player;
    [SerializeField] GameObject buildUI;
    [SerializeField] GameObject buttons;
    Text moneycount;
    public static bool buildMode = false;
    // Start is called before the first frame update
    void Start()
    {
        moneycount = FindObjectOfType<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            buildMode = !buildMode;
            g.SetActive(buildMode);
            objPlace.SetActive(buildMode);
            buildUI.SetActive(buildMode);
            buttons.SetActive(buildMode);
        }
        if (buildMode == true)
        {
            moneycount.text = "BUILD MODE ACTIVE";
        }
        else
        {
            moneycount.text = "Money: " + Money.count;
        }
    }
}
