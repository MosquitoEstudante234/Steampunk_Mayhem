using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meters : MonoBehaviour
{
    public float Meter;
    public Text meterTxt;
    void Start()
    {
        
    }

    public void Update()
    {
        meterTxt.text = "Meters:"+ Meter.ToString();
    }
    public void FixedUpdate()
    {
    Meter++;
    }
}
