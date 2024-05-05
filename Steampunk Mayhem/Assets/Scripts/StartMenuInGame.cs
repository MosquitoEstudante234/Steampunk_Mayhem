using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuInGame : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject StartMenuUI;
    public GameObject GameClick;


    void Start()
    {
    Time.timeScale = 0f;
    }

    void Update()
    {
       /* if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        } */

    }
    public void Resume()
    {
        StartMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        GameClick.SetActive(true);
    }
    public void Pause()
    {
        StartMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }


   

}
