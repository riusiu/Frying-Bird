using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    private const string MAIN_CAMERA_TAG_NAME = "MainCamera";//メインカメラのタグ名
    private bool Rendered = false;//カメラに映っているか判定する変数

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Rendered == true)//もしRenderedがtrueなら、
        {
            transform.Translate(-0.05f, 0, 0);
        }
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
    void OnWillRenderObject()//カメラに映ってる間に呼ばれ続ける処理
    {
        if (Camera.current.tag == MAIN_CAMERA_TAG_NAME)//もしメインカメラに映ったら、
        {
            Rendered = true;//Renderedをtrueにする
        }
    }
}
