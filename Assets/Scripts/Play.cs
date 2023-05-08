using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      public void PlayGame ()
    {
       SceneManager.LoadScene(1);
       Obstacle.lives = 3;
       PauseMenu.isPaused = false;
    }

    public void MainMenu ()
    {
       SceneManager.LoadScene(0);
       Time.timeScale = 1;
    }

       public void ExitGame ()
    {
        Debug.Log ("See ya soon!");
        Application.Quit();
    }

}
