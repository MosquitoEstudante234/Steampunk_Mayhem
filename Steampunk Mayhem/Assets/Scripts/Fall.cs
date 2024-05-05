using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fall : MonoBehaviour
{
    float Randoms;
    GameObject SlowModeButton; 
    public float velocidade;
 
    private void Start()
    {
        Randoms = Random.Range(5.0f, 10.0f);
        velocidade = Random.Range(5.0f, 10.0f);
        SlowModeButton = GameObject.FindWithTag("SlowModeButton");
    }
    void Update()
    {
       
        transform.Translate(Vector3.down * velocidade * Time.deltaTime);
        if (transform.position.y <= -20)
        {
            Destroy(gameObject);

        }

    }
    void FixedUpdate()
    {
        if (SlowModeButton.GetComponent<SlowModeScript>().IsSlowed == true)
        {
            velocidade = 1f;
        } else 
        {
            velocidade = Randoms;
        }
    }
}


