using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answers : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager; //manda  llamar la clase quizmager
   // public AudioSource audio;
   // public AudioSource audio;

   
    public   MensajeText mensajeText ; //para que aparezcan los mensajes de bien hecho o vuelve a intentarlo


    public Color startColor;

    private void Start()
    {
        startColor = GetComponent<Image>().color;
    }


    public void Answer()
    {
        if (isCorrect)
        {
            //      audio.Play();
            //GetComponent<Image>().color = Color.green;
            Debug.Log("Respuesta Correcta");
            
              //condicion si no existe el objeto que contiene el mensaje que se va a mostra en pantalla
            
            /*
            if (MensajeText)
            {
                mensajeText();
            }
            */

            

            quizManager.correct();
             
        
        }
        else
        {
            //GetComponent<Image>().color = Color.red;
            Debug.Log("Respuesta incorrecta, tu puedes ");
            quizManager.wrong();
        }
    }

/*
     //Fun para mostrar si es correcto que vuelva a intentar
    public void mostrarCoreectOrNot()
    {
        GameObject texto = Instantiate(MensajeText); //instancia el objeto de MensajeText
        //con esto indicamos en donde queremos que aparezca el texto
        texto.transform.position = new Vector3(this.GameObject.transform.position.x,
        this.GameObject.transform.position.y,
        this.GameObject.transform.position.z);

    }
  */  
}
