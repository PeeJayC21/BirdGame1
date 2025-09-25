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
    private readonly List<int> scoreList = new List<int>();

    private bool isPaused = false;

    private bool isGameOver = false;


    [ContextMenu("Increase Score:")]
    public void AddScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();

        if (playerScore > getHighestScore())
        {
            highestScoreText.SetText(playerScore.ToString());
        }

    }
    public void storeScore()
    {
        scoreList.Add(highestScore);
        saveHighestScore();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        isGameOver = true;
        highestScore = playerScore;
        storeScore();
        AudioManager.instance.musicSource.Stop();
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

    public void TogglePause()
    {
        isPaused = true;
        Time.timeScale = 0.0f;
    }

    public void ToggleResume()
    {
        isPaused = false;
        Time.timeScale = 1.0f;
    }

    public void ToggleMainMenu()
    {
        SceneManager.LoadScene(1);
        if (AudioManager.instance.musicSource.isPlaying)
        {
            AudioManager.instance.musicSource.Stop();
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public bool getIsPaused()
    {
        return isPaused;
    }

    public bool GetIsGameOver()
    {
        return isGameOver;
    }

}
