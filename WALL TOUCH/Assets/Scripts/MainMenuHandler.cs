using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuHandler : MonoBehaviour
{
    [SerializeField] Text currentScore;
    [SerializeField] Text highScore;


    private void Start()
    {
        currentScore.text = PlayerPrefs.GetInt("score").ToString();
        if(PlayerPrefs.GetInt("score")>PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("score"));
        }
        highScore.text = PlayerPrefs.GetInt("HighScore").ToString();
    }
    public void StartGame()
    {
        SceneManager.LoadScene(3);
    }
    public void Retry()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
