using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections.Generic;

public class LogicSCript : MonoBehaviour
{
    //initialised the variables needed
    public int playerScore;
    public Text scoreText;
    public TMP_Text highestScoreText;
    public GameObject gameOverScreen;
    public int highestScore;
    private List<int> scoreList = new List<int>();


    [ContextMenu("Increase Score:")]
    public void AddScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }
    public void storeScore()
    {
        scoreList.Add(highestScore);
        saveHighestScore();
        printHighestScore();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        highestScore = playerScore;
        storeScore();
        gameOverScreen.SetActive(true);
    }

    public int getHighestScore()
    {
        return PlayerPrefs.GetInt("HighestScore", 0);
    }

    private void saveHighestScore()
    {
        int currentHighest = getHighestScore();
        if (highestScore > currentHighest)
        {
            PlayerPrefs.SetInt("HighestScore", highestScore);
            PlayerPrefs.Save(); // Force save to disk
        }
    }

    public void printHighestScore()
    {
        highestScoreText.SetText(getHighestScore().ToString());
    }
    void Start()
    {
        printHighestScore();
    }
    
    // this supposedly update the highscore once player beats the current once
    // void Update()
    // {
    //     printHighestScore();
    // }
}
