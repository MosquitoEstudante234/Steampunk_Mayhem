using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{

    public float velocidade;

    void Update()
    {
        transform.Translate(Vector3.down * velocidade * Time.deltaTime);
        if (transform.position.y <= -10)
        {
            Destroy(gameObject);

        }

    }
    private void Start()
    {
        velocidade = Random.Range(5.0f, 10.0f);
    }
}


