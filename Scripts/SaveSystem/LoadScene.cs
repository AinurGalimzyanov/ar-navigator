using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        ChangeScene(0);
    }

    public void ChangeScene(int _number)
    {
        SceneManager.LoadScene(_number);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
