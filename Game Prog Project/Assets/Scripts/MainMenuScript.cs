using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //SceneManager.LoadScene("MainGame");
    }
    /*
    public void GameSetting()
    {
        //SceneManager.LoadScene("");
    }*/
    public void QuitGame() {
        Application.Quit();
    }
}