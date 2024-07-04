using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class damage : MonoBehaviour
{
    public HP hpScript;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "arrow")
        {
            hpScript.hp -= 1f;
        }

        if (collision.gameObject.tag == "fire")
        {
            hpScript.hp -= 2f;
        }
    }
}
