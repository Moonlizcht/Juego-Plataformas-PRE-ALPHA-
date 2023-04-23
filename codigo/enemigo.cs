using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour {

public string clonBala;

float SpeedEnemigo = 0.6f; //IA

float DistanciaPlayer = 4f; //IA

Vector3 posicionInicial; //A

public GameObject player; //IA

void Start(){
player = GameObject.FindGameObjectWithTag("Player"); //IA
posicionInicial = transform.position; //IA

}

void Update(){
Vector3 Objetivo = posicionInicial; //IA
float distancia = Vector3.Distance(player.transform.position,transform.position);

if(distancia < DistanciaPlayer){ //IA
    Objetivo= player.transform.position; //IA
}
float Velocidadfija = SpeedEnemigo*Time.deltaTime; //IA
transform.position = Vector3.MoveTowards(transform.position,Objetivo,Velocidadfija); //IA

Debug.DrawLine(transform.position, Objetivo, Color.green); //IA se visualiza en escena

}




void OnTriggerEnter2D(Collider2D col){

    clonBala = col.gameObject.name;
    if(clonBala == "balafuego(Clone)"){
        principalScript.Enemigos++;
        Destroy(this.gameObject, 0.3f);
    }
    if(clonBala == "Personaje"){
        principalScript.Vida--;
        player.transform.position = new Vector2 (-0.6f,-1.49f);
    }
    }

}






