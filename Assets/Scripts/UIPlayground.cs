using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIPlayground : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI finishOverText;
    GameObject essentialUI;

    void Start()
    {
        essentialUI = GameObject.Find("Essentials");
        essentialUI.SetActive(false);
        gameOverText.gameObject.SetActive(false);
        finishOverText.gameObject.SetActive(false);
    }

    public void Finish()
    {
        finishOverText.gameObject.SetActive(true);
        essentialUI.SetActive(true);
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        essentialUI.SetActive(true);
    }
}
