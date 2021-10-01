using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PreStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("StartLevel", 5f);
    }
    void StartLevel()
    {
        SceneManager.LoadScene(2);
    }
}
