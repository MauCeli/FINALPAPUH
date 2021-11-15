using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    public GameObject prefab;
    public float tiempoInicio = 0;
    public float tiempoRep = 1;
    void Start()
    {
        InvokeRepeating("Generar", tiempoInicio, tiempoRep);
    }

    // Update is called once per frame
    void Generar()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
}
