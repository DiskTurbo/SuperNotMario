using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    void Start()
    {
        Invoke("StartLevel", 5f);
    }
    void StartLevel()
    {
        SceneManager.LoadScene(0);
    }
}
