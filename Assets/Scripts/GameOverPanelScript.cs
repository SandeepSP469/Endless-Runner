using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPanelScript : MonoBehaviour
{

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Assets/Scenes/MainMenuScene.unity");
    }

    public void LoadSampleMenu()
    {
        SceneManager.LoadScene("Assets/Scenes/Game.unity");
    }
}
