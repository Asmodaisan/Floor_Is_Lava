using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameActive;
    public int score;
    GameObject player;
    UIPlayground playgroundUI;

    void Start()
    {
        isGameActive = true;
        player = GameObject.Find("PlayerArmature");
        playgroundUI = GameObject.Find("Canvas").GetComponent<UIPlayground>();
    }

    void Update()
    {
        if (player.transform.position.y < -1.28)
        {
            GameOver();
        }
        if (isGameActive)
        {
            score = GameObject.Find("PlayerArmature").GetComponent<JumpCounter>().jumpCounter;
            MainManager.Instance.score = score;
        }
    }

    public void Finish()
    {
        playgroundUI.Finish();
        isGameActive = false;
        player.SetActive(false);
    }

    public void GameOver()
    {
        isGameActive = false;
        playgroundUI.GameOver();
        player.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
