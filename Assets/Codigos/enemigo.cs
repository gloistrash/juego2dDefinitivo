using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    public string clonbala;
    float velocidadenemigo = 0.6f;

    float DistanciaPlayer = 4f;

    Vector3 PosicionOriginal;

    public GameObject player;
    public GameObject gestorSonido;
    private AudioSource emisorEnemigo;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        PosicionOriginal = transform.position;
        emisorEnemigo = GetComponent <AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Objetivo = PosicionOriginal;
        float Distancia = Vector3.Distance(player.transform.position, transform.position);
        if(Distancia < DistanciaPlayer){
            Objetivo = player.transform.position;

        }

        float Velocidad = velocidadenemigo*Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, Objetivo, Velocidad);       
    }

    void OnTriggerEnter2D(Collider2D otro){
        clonbala = otro.gameObject.name;

        if(clonbala == "balafuego(Clone)"){
            emisorEnemigo.PlayOneShot(gestorSonido.GetComponent<AudioManager>().sonidoBola ,1f);
            principalScript.enemigos -=1;
            Destroy(this.gameObject, 0.3f);
        }

        if(clonbala =="Personaje"){
            principalScript.Vida -=1;
            player.transform.position = new Vector3 (0.02526699f,0.5349998f,0f);
            gestorSonido.GetComponent<AudioManager>().sonidoDead();
        }

    }
}
