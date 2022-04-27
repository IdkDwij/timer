using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class timer : MonoBehaviour
{
    public Text gettimer;
    public Text timeleft;
    private int timertime;
    public void startTimer()
    {
        int.TryParse(gettimer.text, out timertime);
        timeleft.text = "Time left: " + timertime;
        InvokeRepeating("Subtract",1f,1f);
    }
    public void Subtract() 
    {
        if (timertime != 0)
        {
        timertime -= 1;
        timeleft.text = "Time left: " + timertime;
        }
        else
        {
            timeleft.text = "Timer Done";

        }
    }
}
