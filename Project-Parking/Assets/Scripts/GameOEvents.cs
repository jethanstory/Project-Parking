//Change scene event system
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOEvents : MonoBehaviour
{
    // Start is called before the first frame update
    public void MenuGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame() 
    {
        SceneManager.LoadScene("Level_1");
    }
    public void nextLevel()
    {
        SceneManager.LoadScene("Level_2");
    }
}