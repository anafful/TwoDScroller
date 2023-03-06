using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject gameOverMenu;
    public GameObject WinGame;




    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
    }


    private void OnEnable()
    {
        Timer.OnTimerEnds += EnableGameOverMenu;
        Timer.OnSuccessWin += EnableWinMenu;
    }

    private void OnDisable()
    {
        Timer.OnTimerEnds -= EnableGameOverMenu;
        Timer.OnSuccessWin -= EnableWinMenu;
    }
    public void EnableGameOverMenu()
    {
        gameOverMenu.SetActive(true);
    }

    public void EnableWinMenu()
    {
        WinGame.SetActive(true);    
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
