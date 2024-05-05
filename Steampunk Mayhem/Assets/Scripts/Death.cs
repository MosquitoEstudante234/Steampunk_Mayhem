using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public static bool IsDead;

    public void OnTriggerEnter2D(Collider2D col)
    { 
        if (col.CompareTag("Death]"))
        {
            IsDead = true;
        }
    }
}
