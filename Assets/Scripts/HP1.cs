using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UIを使うときに書きます。

public class Player : MonoBehaviour
{
    //最大HPと現在のHP。
    int maxHp = 6;
    int Hp;
    //Slider
    public Slider slider;

    void Start()
    {
        //Sliderを最大にする。
        slider.value = 6;
        //HPを最大HPと同じ値に。
        Hp = 2;
    }

    private void OnTriggerEnter(Collider collider)
    {
        //タグを設定しているオブジェクトに接触したとき
        if (collider.gameObject.tag == "Player")
        {
            //HPから1を引く
            Hp = Hp - 1;

            //HPをSliderに反映。
            slider.value = (float)Hp;

        }
    }
}