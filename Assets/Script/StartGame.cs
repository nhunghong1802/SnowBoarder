using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
   public void startGame()
    {
        SceneManager.LoadScene(1);
    } 
    public void loadToOptionsMenu()
    {
        SceneManager.LoadScene("OptionsMenu");
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
