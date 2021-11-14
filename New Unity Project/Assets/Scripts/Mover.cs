using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Mover : MonoBehaviour
{
    public float velx = 10;
    public float jump = 6f;
    public Rigidbody rb;
    public int puntuacion;
    public Text pts;

    void Awake()
    {
        puntuacion = 0;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        actualizarPts();

    }
    

    // Update is called once per frame
    void Update()
    {   
      
       
            transform.Translate(Input.GetAxis("Horizontal") * velx * Time.deltaTime, 0, 0);
 
        

        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jump;
            enabled = false;
        }
    }
    private void OnCollisionEnter(Collision colision)
    {
        enabled = true;
        actualizarPts();
    }
    void OnTriggerEnter(Collider obj)
    {
        puntuacion++;
        obj.gameObject.SetActive(false);
        actualizarPts();


    }
    void actualizarPts()
    {
        pts.text = "PUNTOS: " + puntuacion.ToString();
    }

}
