using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DodgeScript : MonoBehaviour
{
    public Button DodgeButton;
    public GameObject shield, deathcol;
    public void Dodge()
    {
        deathcol.SetActive(false);
        DodgeButton.interactable = false;
        shield.SetActive(true);
        StartCoroutine(NoCollider());
        StartCoroutine(Cooldown());
    }
    public IEnumerator NoCollider()
    {
        yield return new WaitForSeconds(2);
        shield.SetActive(false);
        deathcol.SetActive(true);
    }
     public IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(5);
        DodgeButton.interactable = true;
    }
}
