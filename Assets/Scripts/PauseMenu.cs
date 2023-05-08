using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;

    void Update()
    {

    }
    public void Resume()
    {
        isPaused = false;
        Time.timeScale = 1;
    }

    public void Pause()
    {
        isPaused = true;
        Time.timeScale = 0;
    }

    public void MainMenu ()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void Restart ()
    {
        isPaused = false;
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
        Obstacle.lives = 3;
    }
    
}
