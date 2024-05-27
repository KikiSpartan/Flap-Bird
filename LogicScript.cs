using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public double playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
        
    [ContextMenu("Increase Score")]
   public void addScore()
    {
        playerScore += 0.5;
        //playerScore = (playerScore) + (0.5);
        scoreText.text = playerScore.ToString();
        
    }

     public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }


}
