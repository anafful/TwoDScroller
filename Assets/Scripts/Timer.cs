using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float duration = 60, currentTime;
    public bool timerIsRunning = false;
    public TMP_Text timeText;

    

    public delegate void TimerEventHandler(float timeRemaining);
    public static event TimerEventHandler OnTimerTick;




    private void Start()
    {
        // Starts the timer
        timerIsRunning = true;
        currentTime = duration;
    }




    void Update()
    {
        if (timerIsRunning)
        {
            if (duration > 0)
            {
                duration -= Time.deltaTime;
                DisplayTime(duration);
            }
            else
            {
                Debug.Log("Time has run out!");
                duration = 0;
                timerIsRunning = false;
                
                // respawn to beginning or open menu page
            }

         
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        OnTimerTick?.Invoke(timeToDisplay);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            timerIsRunning = false;
            Debug.Log("Made it home");
        }
    }
}

