using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReiniciarJuego : MonoBehaviour
{
    public Text puntajeUI;

    public void Awake()
    {
        puntajeUI.text = "puntaje = " + PreguntaManager.sPreguntaManager.puntaje.ToString();
    }

    public void Reiniciar()
    {
       // Destroy(gameObject.Find("Pregunta Manager"));
        SceneManager.LoadScene("SampleScene");
    }
}
