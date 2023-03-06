using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DayAndNightCycle : MonoBehaviour
{
    public float dayLengthInSeconds = 120f;
    public float sunAngleAtNoon = 90f;
    public Gradient skyColorGradient;

    public Transform sunOrMoon;
    public float cycleDuration = 120f;


    private float timer = 0f;

    public static DayAndNightCycle instance;

    private void Start()
    {
        instance = this;
        sunOrMoon.rotation = Quaternion.Euler(90f, 0f, 0f);

    }

    void OnEnable()
    {
        Timer.OnTimerTick += HandleTimerTick;
    }

    void OnDisable()
    {
        Timer.OnTimerTick -= HandleTimerTick;
    }

    private void Update()
    {
        

    }

    void SetProgress(float progress)
    {
        // Set the rotation of the sun/moon based on the progress of the cycle
        float rotation = progress * 360f; // convert progress from 0-1 to degrees
        sunOrMoon.rotation = Quaternion.Euler(rotation, 0f, 0f);
    }

    void HandleTimerTick(float timeRemaining)
    {
        // Update the day/night cycle based on the timer
        float duration = 60f;
        float t = timer / dayLengthInSeconds;
        float cycleProgress = (duration - timeRemaining) / duration;
        //float skyColorT = Mathf.Clamp01(t * 2f - 0.5f);
        //RenderSettings.skybox.SetColor("_Tint", skyColorGradient.Evaluate(skyColorT));

        SetProgress(cycleProgress);
    }
}
