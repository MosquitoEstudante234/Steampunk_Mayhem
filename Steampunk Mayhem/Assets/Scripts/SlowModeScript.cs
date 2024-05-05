using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlowModeScript : MonoBehaviour
{
    public bool IsSlowed;
    public Button SlowModeButton;
    public GameObject SpawnAct1, SpawnAct2;
  
    public void Awake()
    {

    }
  public void SlowMode()
    {
        SpawnAct1.SetActive(false);
        SpawnAct2.SetActive(false);
        IsSlowed = true;
        SlowModeButton.interactable = false;
        StartCoroutine(NoCollider());
        StartCoroutine(Cooldown());
    }
    public IEnumerator NoCollider()
    {
        yield return new WaitForSeconds(15);
        IsSlowed = false;
        SpawnAct1.SetActive(true);
        SpawnAct2.SetActive(true);
    }
     public IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(50);
        SlowModeButton.interactable = true;
    } 
}
