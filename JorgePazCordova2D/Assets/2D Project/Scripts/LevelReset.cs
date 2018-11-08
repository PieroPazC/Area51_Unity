﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelReset : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "PlatformChar")
        {
            if (SceneManager.sceneCountInBuildSettings == SceneManager.GetActiveScene().buildIndex)
            {
                SceneManager.LoadScene(0);
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}

