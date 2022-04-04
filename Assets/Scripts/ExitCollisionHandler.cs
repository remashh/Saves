using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitCollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        if (index == 1 & other.gameObject.CompareTag("Player") & ScoreController.CoinCount >= 10)
        {
            MainMenu.SetLoad = false;
            SceneManager.LoadScene(index + 1);
        }

        if (index == 2 & other.gameObject.CompareTag("Player") & ScoreController.CoinCount >= 10)
        {
            MainMenu.SetLoad = false;
            SceneManager.LoadScene(index + 1);
        }
    }
}
