using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutOfTheMap : MonoBehaviour
{
    Scene scene;
    private void Start()
    {
       scene  = SceneManager.GetActiveScene();
    }
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("GameOver");
    }
}
