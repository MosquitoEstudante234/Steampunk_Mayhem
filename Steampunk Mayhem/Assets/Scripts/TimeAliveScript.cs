using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeAliveScript : MonoBehaviour
{
    private float timer = 0f;
     public Text TimerTxt;

    private void Start()
    {
        InvokeRepeating("IncreaseTimer", 1f, 1f);
    }

    void IncreaseTimer()
    {
        timer += 1f;
        TimerTxt.text = "Time Alive:"+ timer.ToString();
    }
}
