using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;



public class timer : MonoBehaviour
{
    public Text timerText;
    public static float startTime;
    public static string score;

    void Start()
    {
        startTime = Time.time;
    }
    void Update()
    {
        float t = Time.time - startTime;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f0");
        timerText.text = minutes +":"+ seconds;
        timer.score = minutes + ":" + seconds+"s";
        
    }
}
