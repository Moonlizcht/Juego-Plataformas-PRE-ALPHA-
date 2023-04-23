using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguircamara : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Transform personaje;
    public float dondepersonaje;
    public float dondepersonajeY;

    // Update is called once per frame
    void Update()
    {
       dondepersonaje = personaje.transform.position.x;
       dondepersonajeY = personaje.transform.position.y;
       transform.position = new Vector3 (dondepersonaje, dondepersonajeY, -10); 
    }
}
