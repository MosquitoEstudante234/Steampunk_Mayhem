using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinRainScript : MonoBehaviour
{
    public GameObject SpawnerAct1, SpawnerAct2, SpawnerDea1, SpawnerDea2;
    public Button CoinRainButton;
    public void CoinRain()
    {
        CoinRainButton.interactable = false;
        SpawnerDea1.SetActive(false);
        SpawnerDea2.SetActive(false);
        SpawnerAct1.SetActive(true);
        SpawnerAct2.SetActive(true);
        StartCoroutine(NoEnemies());
        StartCoroutine(Cooldown());
    }
    public IEnumerator NoEnemies()
    {
        yield return new WaitForSeconds(10);
        SpawnerDea1.SetActive(true);
        SpawnerDea2.SetActive(true);
        SpawnerAct1.SetActive(false);
        SpawnerAct2.SetActive(false);
    }
     public IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(30);
        CoinRainButton.interactable = true;

    }
}
