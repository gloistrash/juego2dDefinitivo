using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    public GameObject Personaje;
    public GameObject gestorSonido;
    private static int contadorTrigger;
    
    // Start is called before the first frame update
    void Start()
    {
        contadorTrigger = 0;


        //Personaje = GameObject.Find("Personaje");
        //personaje = find("personaje");
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log (contadorTrigger);
        
    }
    void OnTriggerEnter2D (Collider2D otro) {

        if(contadorTrigger <= 0){
            Debug.Log("EfectoEco");
            contadorTrigger++;
        }else if (contadorTrigger >= 1){
            Debug.Log("ha susedido la susedura x_x");
        //gestorSonido.GetComponent<AudioSource>().PlayOneShot(gestorSonido.GetComponent<AudioManager>().sonidoMuerte,1f);
        gestorSonido.GetComponent<AudioManager>().sonidoDead();
        principalScript.Vida = -1;
        Personaje.transform.position = new Vector3 (0.02526699f,0.5349998f,0f);
        contadorTrigger++;

        }

        



        
    }
    void OnTriggerEnter2D (){
        contadorTrigger --;
    }
}
