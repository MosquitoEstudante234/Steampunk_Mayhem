using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeAliveScript : MonoBehaviour
{
    public static float timer = 0f;
     public Text TimerTxt;

    private void Start()
    {
        timer = 0f;
        InvokeRepeating("IncreaseTimer", 1f, 1f);
    }

    void IncreaseTimer()
    {
        timer += 1f;
        TimerTxt.text = "Time      Alive:"+ timer.ToString();
    }
}
