using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargarScena : MonoBehaviour
{
    public void Escena(string Menu)
    {
        SceneManager.LoadScene(Menu);
    }
}
