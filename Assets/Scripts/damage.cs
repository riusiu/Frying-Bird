using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class damage : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            UnityEngine.Debug.Log("Ouch!");
        }

        if (collision.gameObject.tag == "fire")
        {
            UnityEngine.Debug.Log("Ouch!");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
