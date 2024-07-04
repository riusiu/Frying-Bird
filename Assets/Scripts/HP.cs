using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public float hp = 6;
    public Image hpBar;
    
    private void Update()
    {
        hpBar.fillAmount = (hp/6);
        if (hp == 0) {
            SceneManager.LoadScene("OtherSceneName");
        }
    }


}