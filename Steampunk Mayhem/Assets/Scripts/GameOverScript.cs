using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{

    public static float ScoreFinal, MetersFinal, TimeAliveFinal;
    public Text ScoreFinalTxt, MetersFinalTxt, TimeAliveFinalTxt;
    public GameObject Music;
    

    
    public void Awake()
    {
    if (MetersFinal <= Meters.Meter)
    {
    MetersFinal = Meters.Meter;
    }
    if (ScoreFinal <= Score.score)
    {
    ScoreFinal = Score.score;
    }
    if (TimeAliveFinal <= TimeAliveScript.timer)
    {
    TimeAliveFinal = TimeAliveScript.timer;
    }
    if (TimeAliveFinal <= TimeAliveScript.timer || ScoreFinal <= Score.score || MetersFinal <= Meters.Meter)
    {
        FindObjectOfType<AudioManager>().Play("NewHighScore");
    }
    }
    void Start()
    {
        ScoreFinalTxt.text = "Score:"+ ScoreFinal.ToString();
        MetersFinalTxt.text = "Meters:"+ MetersFinal.ToString() + "m";
        TimeAliveFinalTxt.text = "Time Alive:"+ TimeAliveFinal.ToString() + "s";
        Time.timeScale = 0f;
        FindObjectOfType<AudioManager>().Play("Defeat");
        Music.SetActive(false);
    }

   


    void Update()
    {
        
    }
}
