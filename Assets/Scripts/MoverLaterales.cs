using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverLaterales : MonoBehaviour
{
    public Transform target;
    public Transform target2;
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
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            if (transform.position == target.position)
            {
                bandera = false;
            }

        }
        else
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target2.position, step);
            if (transform.position == target2.position)
            {
                bandera = true;
            }
        }


    }
}
