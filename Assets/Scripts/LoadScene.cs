using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
  public void CargarScena(string Vocales)
    {
        //SeceneManger es un metodo estatico
        SceneManager.LoadScene(Vocales);
    }
}
