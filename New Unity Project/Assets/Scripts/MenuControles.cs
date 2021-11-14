using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuControles : MonoBehaviour
{
    public void cargarJuego()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }

    
}
