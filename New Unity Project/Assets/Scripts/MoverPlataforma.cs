using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPlataforma : MonoBehaviour
{
    public float velz = 300f;
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, velz * Time.deltaTime);
    }

   
}
