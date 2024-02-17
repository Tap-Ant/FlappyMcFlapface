using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logic : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject gameStartScreen;
    public GameObject bird;
    public GameObject pipeSpawner;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = score.ToString();
    }

    public void startGame()
    {
        gameStartScreen.SetActive(false);
        bird.SetActive(true);
        pipeSpawner.SetActive(true);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameStartScreen.SetActive(false);
        bird.SetActive(true);
        pipeSpawner.SetActive(true);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
