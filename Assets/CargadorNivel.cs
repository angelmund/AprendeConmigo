using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Libreria para cargar escenas
using UnityEngine.UI;
public class CargadorNivel : MonoBehaviour
{
    public GameObject pantallaDeCarga;
    public Slider Slider;
    public void CargarNivel(int NumeroDeEscena)
    {
        StartCoroutine(CargarAsync(NumeroDeEscena));
        
    }
    
    IEnumerator CargarAsync(int NumeroDeEscena)
    {
        AsyncOperation Operacion = SceneManager.LoadSceneAsync(NumeroDeEscena);  //Significa que vamos a cargar nuestra escena de manera asincrónica
        pantallaDeCarga.SetActive(true);

        while(!Operacion.isDone)
           
        {
            float Progreso = Mathf.Clamp01(Operacion.progress / .9f);
            Slider.value = Progreso;

            yield return null;
        }
    }
}
