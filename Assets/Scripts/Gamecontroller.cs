using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;


public class Gamecontroller : MonoBehaviour
{
    public static Gamecontroller instance;
    public Text scoreText;
    public Text gameOverScoreText;
    public GameObject gameoverText;
    public bool isGameOver = false;
    public  PlayerController player;
    private int score = 0;

    public GameObject gameWinLayout;
    public Text gameWinText;
    public bool gameWin = false;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }else if (instance == this)
        {
            Destroy(gameObject);
        }
    }
    
    public void addScore(int score)
    {
        this.score += score;
        scoreText.text = ""+ this.score;
        if (this.score == 100)
        {
            GameWin();
        }
    }
    public void GameOver()
    {
        gameOverScoreText.text = "Your score : " + score;
        gameoverText.SetActive(true);
        isGameOver = true;
    }
    public void GameWin()
    {
        gameWinText.text = "Your score : " + score;
        gameWinLayout.SetActive(true);
        gameWin = true;
    }

}
