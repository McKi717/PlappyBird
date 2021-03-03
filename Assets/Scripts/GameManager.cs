using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text Score;
    public static int score;
    public GameObject DeadScreen;
    public Text YourScoreDead;
    private int bestScore;
    public Text BestScore;
    public bool gameIsPaused=false;
    private void Awake()
    {
        bestScore = PlayerPrefs.GetInt("best score", 0);
    }
    private void Update()
    {
        Score.text = "" + score;
        if (score > bestScore)
        {
            bestScore = score;
            PlayerPrefs.SetInt("best score", bestScore);
        }
        if ( gameIsPaused&&Input.GetKeyDown(KeyCode.Space) )
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1f;
        }
        
    }
    public void DeadScrn()
    {
        gameIsPaused = true;
        Time.timeScale = 0f;
        DeadScreen.SetActive(true);
        YourScoreDead.text = "Your Score:" + score;
        BestScore.text = "Best Score:" + bestScore;
    }
   

}
