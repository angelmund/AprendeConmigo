using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MensajeText : MonoBehaviour
{
    public float Tiempo = 2; //tiempo que aparece el texto
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Tiempo -= Time.deltaTime;
        if(Tiempo <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
