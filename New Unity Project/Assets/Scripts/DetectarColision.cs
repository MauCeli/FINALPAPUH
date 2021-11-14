using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectarColision : MonoBehaviour
{
    int cantidadVida = 3;
    void Start()
    {

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider colision)
    {
        if (colision.gameObject.tag == "enemigo1")
        {
            Debug.Log("Detecto collision");
            cantidadVida--;
            if (cantidadVida == 0)
            {
                finJuego();
                Destroy(gameObject);
            }

        }
    }

    public void finJuego()
    {
        SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
    }
}
