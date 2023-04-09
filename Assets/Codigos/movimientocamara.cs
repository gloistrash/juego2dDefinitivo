using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientocamara : MonoBehaviour
{

    public Transform Personaje;
    private float dondePersonajeX;
    private float dondePersonajeY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Donde esta el personaje
        dondePersonajeX = Personaje.transform.position.x;
        dondePersonajeY = Personaje.transform.position.y;

        //Muevo a la cámara
        transform.position = new Vector3(dondePersonajeX,dondePersonajeY,-10);
        
    }
}
