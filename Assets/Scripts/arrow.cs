using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(6, -1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.06f, 0, 0);
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
