using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour
{
    public void change_button()
    {
        SceneManager.LoadScene("Level1");
    }
}
