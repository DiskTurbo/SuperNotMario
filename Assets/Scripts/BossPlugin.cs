using System.Collections;
using System.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

public class BossPlugin : MonoBehaviour
{
    Vector2 scale;

    public static float walkspeed;

    [DllImport("INFR3110-F2021")]
    private static extern void SetBossStats(float x, float y, float speed);
    [DllImport("INFR3110-F2021")]
    private static extern void GetScale(float x, float y);
    // Start is called before the first frame update
    void Start()
    {
        //SetBossStats(this.transform.localScale.x, this.transform.localScale.y, walkspeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
