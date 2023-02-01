using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Abecedario : MonoBehaviour
{
   public void Abc(string Abecedario)
    {
        SceneManager.LoadScene(Abecedario);
    }
}
