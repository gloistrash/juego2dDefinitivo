using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptStart : MonoBehaviour


{
    public GameObject CanvasStart;
    public GameObject CanvasControles;
    // Start is called before the first frame update
    void Start()
    {
        CanvasControles.SetActive(false);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EntrarJuego(){
        SceneManager.LoadScene("nivel1");
    }

    public void mostrarControles(){
        CanvasStart.SetActive(false);
         CanvasControles.SetActive(true);
    }
    public void IrAStart(){
         CanvasStart.SetActive(true);
         CanvasControles.SetActive(false);

    }



}
