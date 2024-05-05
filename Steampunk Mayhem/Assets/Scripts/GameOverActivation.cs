using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverActivation : MonoBehaviour
{
    public GameObject GameOverScreen;
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        if (Death.IsDead == true)
        {
            GameOverScreen.SetActive(true);
            Death.IsDead = false;
        }
    }
}
