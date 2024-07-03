using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI���g���Ƃ��ɏ����܂��B

public class Player : MonoBehaviour
{
    //�ő�HP�ƌ��݂�HP�B
    int maxHp = 6;
    int Hp;
    //Slider
    public Slider slider;

    void Start()
    {
        //Slider���ő�ɂ���B
        slider.value = 6;
        //HP���ő�HP�Ɠ����l�ɁB
        Hp = 2;
    }

    private void OnTriggerEnter(Collider collider)
    {
        //�^�O��ݒ肵�Ă���I�u�W�F�N�g�ɐڐG�����Ƃ�
        if (collider.gameObject.tag == "Player")
        {
            //HP����1������
            Hp = Hp - 1;

            //HP��Slider�ɔ��f�B
            slider.value = (float)Hp;

        }
    }
}