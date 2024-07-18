using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
小川泰正
ーーーーーーーーーーーーーー
デザインと動きを制作しました
*/

public class Fireball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.03f, 0, 0);
    }

    public class damage : MonoBehaviour
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
