using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextMensaje : MonoBehaviour

{
    public float TiempodeVida = 1;
     public TextMeshProUGUI mensajeCN; //es para mandar el mensaje de muy bien 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
        TiempodeVida -= Time.deltaTime;

        if(TiempodeVida <=0)
        {
            // Destroy(mensajeCN.Find(mensajeCN.name+ "(clone)"));
            Destroy(this.gameObject);
        }
        
    
    }
}
