using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public Animator animator;
    public bool EstaDireita;
    public bool EstaEsquerda;

    void Start()
    {
        animator.SetBool("PuloDir", false);
        animator.SetBool("PuloEsq", false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
         if (EstaDireita)
            {
                animator.SetBool("PuloEsq", true);
            }
            if (EstaEsquerda)
            {
                animator.SetBool("PuloDir", true);
            }
        }
    }
    private void OnTriggerStay2D(Collider2D col)
    {
            if (col.CompareTag("LeftWall"))
            {
                EstaEsquerda = true;
                EstaDireita = false;
            }
            if (col.CompareTag("RightWall"))
            {
                EstaDireita = true;
                EstaEsquerda = false;
            }
       

    }
    private void OnTriggerExit2D(Collider2D col)
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
