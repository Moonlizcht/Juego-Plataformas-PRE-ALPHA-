using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dead : MonoBehaviour
{

    public GameObject Personaje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
    }


        void OnTriggerEnter2D(){
            Debug.Log("Has muerto");
            principalScript.Vida--;
            Personaje.transform.position = new Vector2 (-0.6f,-1.49f);
        }
    
    }

