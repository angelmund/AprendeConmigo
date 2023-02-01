using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PreguntaManager : MonoBehaviour
{
    public static PreguntaManager sPreguntaManager;
    public CargarPregunta cargarPregunta;
    public List<Pregunta> preguntas;

    public int cantidadPreguntas = 10;
    public int index;

    public int puntaje;
    public Text puntajeUI;

    public int preguntasRun;
    public int maxPreguntasRun = 5;

     //public TextMeshProUGUI mensajeCN;

    private void Awake()
    {
        sPreguntaManager = this;
        preguntasRun = 1;

        //No destruir preguntaManager

        DontDestroyOnLoad(gameObject);
        //Pregunta random al inicio
        for (int i = 0; i <= cantidadPreguntas; i ++)
        {
            int a = Random.Range(0, preguntas.Count);
            index = a;
        }
    }

    public void Responder(bool respuestaCorrecta)
    {
        if (respuestaCorrecta)
        {
            sPreguntaManager.puntaje += 100;
        }
        else
        {
            Debug.Log("Wrong");
        }

        //preguntas randorizadas
        for(int i= 0; i<= cantidadPreguntas; i++)
        {
            int a = Random.Range(0, preguntas.Count);
            index = a;
        }

        //solo se realizan las 5 preguntas en este caso las vocales
        if(preguntasRun ==maxPreguntasRun)
        {
            SceneManager.LoadScene("Final");
        }

        //actualizar puntaje
        puntajeUI.text = "Puntaje =" + puntaje.ToString();

        preguntasRun++;
        ShowNextQuestion();
    }

    public void ShowNextQuestion()
    {
        cargarPregunta.pregunta = preguntas[index];
        cargarPregunta.ShowQuestion();
    }

    private void Start()
    {
        ShowNextQuestion();
    }

}
