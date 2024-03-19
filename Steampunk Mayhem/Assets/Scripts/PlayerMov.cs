using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public Animator animator;


    void Start()
    {
        animator.SetBool("PuloDir", true);
        animator.SetBool("PuloEsq", false);
    }
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("LeftWall") && Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("PuloEsq", true);
        }
        if (col.CompareTag("RightWall") && Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("PuloDir", true);
        }
       
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("LeftWall"))
        {
            animator.SetBool("PuloEsq", false);
            animator.SetBool("PuloDir", false);
        }
        if (col.CompareTag("RightWall"))
        {
            animator.SetBool("PuloEsq", false);
            animator.SetBool("PuloDir", false);
        }
    }
}
