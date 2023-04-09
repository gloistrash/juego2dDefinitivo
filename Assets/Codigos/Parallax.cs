using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    public GameObject Personaje;
    public GameObject FondoNubes;
    public GameObject FondoArboles;
    public GameObject ArbolGrande;
    public static string DireccionPersonaje;
    public float VelocidadNubes = 0f;
    public float VelocidadArboles = 0f;
    public float VelocidadArbolGrande = 0f;
    // Start is called before the first frame update
    void Start()
    {


        
    }

    // Update is called once per frame
    void Update()
    {

        if(DireccionPersonaje == "derecha"){
            VelocidadNubes -= 0.1f;
            VelocidadArboles -= 0.05f;
            VelocidadArbolGrande -= 0.15f;

        }
        if(DireccionPersonaje == "izquierda"){
            VelocidadNubes += 0.1f;
            VelocidadArboles += 0.05f;
            VelocidadArbolGrande += 0.15f;

        }
        if(DireccionPersonaje == "parado"){
            VelocidadNubes = 0.0f;
            VelocidadArboles = 0.0f;
            VelocidadArbolGrande = 0.0f;

        }



        FondoNubes.transform.Translate(VelocidadNubes*Time.deltaTime,0,0);
        FondoArboles.transform.Translate(VelocidadArboles*Time.deltaTime,0,0);
        ArbolGrande.transform.Translate(VelocidadArbolGrande*Time.deltaTime,0,0);


        
    }
}
