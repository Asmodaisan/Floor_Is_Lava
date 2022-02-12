using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class JumpCounter : MonoBehaviour
{
    public TextMeshProUGUI CounterText;
    [SerializeField]private int jumpCounter = 0;
    private GameManager gameManager;
    //public Platform platform;
    //BoxCollider playerCl;

    private void Start()
    {
        //platform = GameObject.Find("Platform").GetComponent<Platform>();
        //playerCl = GetComponent<BoxCollider>();
        jumpCounter = 0;
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform") /*&& !platform.wasVisited*/)
        {
            Platform platform = collision.gameObject.GetComponent<Platform>();
            if (!platform.wasVisited)
            {
                platform.wasVisited = true;
                jumpCounter++;
                CounterText.text = "" + jumpCounter;
            }
            /*playerCl.isTrigger = true;
            playerCl.isTrigger = false;*/
        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            gameManager.Finish();
        }
    }
}

/* Right way to implement this counter in all three scripts
 * // Platform 3
public void VisitPlatform()
{
    wasVisited = true;
}

public bool WasPlatformVisited()
{
    return wasVisited;
}

// Player 2

void VisitPlatform(Platform pl)
{
    pl.VisitPlatform();
}

// JumpCounter 1

void OnCollisionEnter(Collision collision)
{
    platfrom = collision.GetObject<Platform>();
    if (!platfrom.WasPlatformVisited())
    {
        GetObject<Player>().VisitPlatform(platfrom);
    }
}*/
