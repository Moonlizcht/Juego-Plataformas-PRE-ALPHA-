using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class principalScript : MonoBehaviour {

public static int Score =0;

public static int Vida = 3;

public static int Enemigos = 0;

public GUISkin miSkin;

public Texture2D logoJuego;

int AnchoPantalla;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
    AnchoPantalla = Screen.width/2;
      /*
      Debug.Log("Vida "+Vida);  
      Debug.Log("Score "+Score);
      Debug.Log("Enemigos "+Enemigos);
      */
    }

    void OnGUI(){
      GUI.skin = miSkin;
      GUI.Label(new Rect(20, 20, 150, 80),"Vida: "+Vida.ToString(), "estiloScore");
      GUI.Label(new Rect(200, 20, 150, 80),"Score: "+Score.ToString(),"estiloScore");
      GUI.Label(new Rect(440, 20, 150, 80),"Enemigos: "+Enemigos.ToString(), "estiloScore");
      GUI.Label(new Rect(1024,20,200,100),"Nombre Juego","estiloTitulo");
      // imagen
      //GUI.DrawTexture(new Rect(Screen.width-200,20,80,80),"logoJuego");  NO FUNCIONA, ERROR DE PASAR STRING A TEXTURA
    }



}
