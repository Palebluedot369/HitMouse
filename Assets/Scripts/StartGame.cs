using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startgame : MonoBehaviour
{
    public void LoadSence(string SampleScene)
    {
        SceneManager.LoadScene(SampleScene);
    }
    public void Start()
    {
        Point.destroycount = 0;
    }

}
