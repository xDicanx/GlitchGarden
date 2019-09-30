﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SplashScreenTimer());
    }

    IEnumerator SplashScreenTimer(){
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Start Screen");
    }
}
