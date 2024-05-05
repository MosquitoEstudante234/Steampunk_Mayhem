using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreTxt;
    public static int score;
    private void Start()
    {

        score = 0;
    }


    private void Update()
    {
        scoreTxt.text = "Score:"+ score.ToString();

    }
    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.CompareTag("Moeda") == true)
        {
            score = score + 500;
            Destroy(col.gameObject);
            FindObjectOfType<AudioManager>().Play("Coin");
        }
    }

}
