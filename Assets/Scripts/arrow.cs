using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    private const string MAIN_CAMERA_TAG_NAME = "MainCamera";//���C���J�����̃^�O��
    private bool Rendered = false;//�J�����ɉf���Ă��邩���肷��ϐ�

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Rendered == true)//����Rendered��true�Ȃ�A
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
    void OnWillRenderObject()//�J�����ɉf���Ă�ԂɌĂ΂ꑱ���鏈��
    {
        if (Camera.current.tag == MAIN_CAMERA_TAG_NAME)//�������C���J�����ɉf������A
        {
            Rendered = true;//Rendered��true�ɂ���
        }
    }
}
