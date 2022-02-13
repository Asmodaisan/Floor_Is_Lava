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
    public TextMeshProUGUI jumpCounterText;
    public TextMeshProUGUI saveScore;
    public TextMeshProUGUI yourScore;
    GameObject essentialUI;
    
    void Start()
    {
        essentialUI = GameObject.Find("Essentials");
        essentialUI.SetActive(false);
        gameOverText.gameObject.SetActive(false);
        finishOverText.gameObject.SetActive(false);
        saveScore.gameObject.SetActive(false);
        yourScore.gameObject.SetActive(false);
    }

    public void Finish()
    {
        jumpCounterText.gameObject.SetActive(false);
        finishOverText.gameObject.SetActive(true);
        essentialUI.SetActive(true);
    }

    public void GameOver()
    {
        jumpCounterText.gameObject.SetActive(false);
        gameOverText.gameObject.SetActive(true);
        yourScore.gameObject.SetActive(true);
        essentialUI.SetActive(true);
    }

    public void SaveScore()
    {
        saveScore.gameObject.SetActive(true);
        MainManager.Instance.SavePlayerData();
    }
}
