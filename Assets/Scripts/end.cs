using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end : MonoBehaviour
{
    public void change_button()
    {
        SceneManager.LoadScene("Stage Select");
    }
}
