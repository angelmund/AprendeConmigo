using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Respuesta : MonoBehaviour
{
    public TextMeshProUGUI mensajeCN; //es para mandar el mensaje de muy bien 
    public bool esCorrecta;

    public void Responder()
    {
        PreguntaManager.sPreguntaManager.Responder(esCorrecta);
           mensajeCN.gameObject.SetActive(true); //muestra el mensaje de muy bien
    }
}
