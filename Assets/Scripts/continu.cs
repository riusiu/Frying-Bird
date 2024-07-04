using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class continu : MonoBehaviour
{
    public void change_button()
    {
        SceneManager.LoadScene("Level1");
    }
}
