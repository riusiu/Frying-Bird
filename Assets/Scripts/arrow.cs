using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(5, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.004f, 0, 0);
    }

    public class damage : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                Destroy(this.gameObject);
            }
        }
    }
}
