using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public float hp = 6f;
    public Image hpBar;

    private void Update()
    {
        hpBar.fillAmount = (hp / 6f);
        if (hp <= 0f)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}