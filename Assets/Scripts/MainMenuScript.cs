using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public Text HighScoreText;
    void Start()
    {
        HighScoreText.text = "High Score : " + PlayerPrefs.GetInt("HighScore");
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("Assets/Scenes/Game.unity");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
