using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI finishOverText;
    public Button restartButton;
    //public GameObject titleScreen;
    public bool isGameActive;
    private int score;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        isGameActive = true;
        player = GameObject.Find("PlayerArmature");
        restartButton.gameObject.SetActive(false);
        gameOverText.gameObject.SetActive(false);
        finishOverText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < -1.28)
        {
            isGameActive = false;
            GameOver();
        }
    }
    public void Finish()
    {
        restartButton.gameObject.SetActive(true);
        finishOverText.gameObject.SetActive(true);
    }

    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        //Destroy(player);
        player.SetActive(false);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    /*public void StartGame()
    {
        isGameActive = true;
        //titleScreen.gameObject.SetActive(false);
    }*/
}
