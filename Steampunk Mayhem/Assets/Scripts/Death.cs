using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Death]"))
        {
            SceneManager.LoadScene("cena1");
        }
    }
}
