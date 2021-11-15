using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RebotarMapa : MonoBehaviour
{
    public Transform pt1;
    public Transform pt2;
    public float speed;
    private bool bandera = true;

    void Start()
    {

    }
    void Update()
    {
        if (bandera)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, pt1.position, step);
            if (transform.position == pt1.position)
            {
                bandera = false;
            }

        }
        else
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, pt2.position, step);
            if (transform.position == pt2.position)
            {
                bandera = true;
            }
        }


    }
}
