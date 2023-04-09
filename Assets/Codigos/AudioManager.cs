using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public AudioClip BandaSonora;
    public AudioClip clicMenu;
    public AudioClip lanzaBola;
    public AudioClip sonidoMuerte;
    public AudioClip sonidoGoal;
    public AudioClip sonidoBola;
    private AudioSource hiloMusical;
    private Scene escenaActual;

    public static GameObject scriptDuplicado;



    void Awake(){
        DontDestroyOnLoad(this.gameObject);
        if(scriptDuplicado == null){
            scriptDuplicado = this.gameObject;
        } else if (scriptDuplicado !=null){
            Object.Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        hiloMusical = GetComponent < AudioSource >();
        hiloMusical.clip = BandaSonora;
        hiloMusical.loop = true;
        hiloMusical.Play();


        
    }




    // Update is called once per frame
    void Update()
    {
        escenaActual = SceneManager.GetActiveScene();
        if(escenaActual.name == "start"){
            hiloMusical.pitch = 1f;

        }else if(escenaActual.name == "nivel1"){
            hiloMusical.volume = 0.4f;
            hiloMusical.pitch = 1.5f;

        }
        
        
    }

    public void clicBoton(){
        hiloMusical.PlayOneShot(clicMenu,1f);


    }

    public void sonidoDead(){
        hiloMusical.PlayOneShot(sonidoMuerte, 1f);
    }

    public void sonidoPuntos(){
        hiloMusical.PlayOneShot(sonidoGoal, 1f);

    }

    
}
