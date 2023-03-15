using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    //public GameObject gameOverMenu;
    public GameObject WinGame;
    public GameObject RetryGameMenu;





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
        Timer.OnSuccessWin += WinNextLevelMenu;
        
        
    }

    private void OnDisable()
    {
        Timer.OnTimerEnds -= EnableGameOverMenu;
        Timer.OnSuccessWin -= WinNextLevelMenu;
    }
    public void EnableGameOverMenu()
    {
        RetryGameMenu.SetActive(true);
    }


    public void WinNextLevelMenu()
    {
        WinGame.SetActive(true);
    }

    public void TryAgainMenu()
    {
        RetryGameMenu.SetActive(true);    
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
