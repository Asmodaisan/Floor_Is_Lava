using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class JumpCounter : MonoBehaviour
{
    public TextMeshProUGUI CounterText;
    public int jumpCounter;
    private GameManager gameManager;

    private void Start()
    {
        jumpCounter = 0;
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            Platform platform = collision.gameObject.GetComponent<Platform>();
            if (!platform.WasPlatformVisited())
            {
                platform.VisitPlatform();
                jumpCounter++;
                CounterText.text = "" + jumpCounter;
            }
        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            gameManager.Finish();
        }
    }
}