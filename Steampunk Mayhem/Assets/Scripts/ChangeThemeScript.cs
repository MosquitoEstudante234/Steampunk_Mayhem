using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeThemeScript : MonoBehaviour
{
    public List<GameObject> Mapas = new List<GameObject>(3);
    public GameObject Spawns, Fade;
    private int id = 0;

    public void Start()
    {
        StartCoroutine(FadeNumerator(id));
    }

    public void Update()
    {

    }

    public IEnumerator FadeNumerator(int id)
    {
        while (true) // Loop infinito para repetir o ciclo
        {
            yield return new WaitForSeconds(Random.Range(30, 50));
            Spawns.SetActive(false);
            yield return new WaitForSeconds(11);
            Fade.SetActive(true);
            yield return new WaitForSeconds(4);
            StartCoroutine(Cooldown());
            Mapas[id].SetActive(false);

            id = (id + 1) % Mapas.Count; // Incrementa o índice e reinicia se chegar ao final
            Mapas[id].SetActive(true);
            yield return new WaitForSeconds(2);
            Fade.SetActive(false);
        }
    }

    public IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(1);
        StartCoroutine(NoSpawns());
    }

    public IEnumerator NoSpawns()
    {
        yield return new WaitForSeconds(1);
        Spawns.SetActive(true);
        Fade.SetActive(false);
    }
}