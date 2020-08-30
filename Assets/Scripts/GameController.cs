using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject[] Estrelas;
    public Scene scene;
    public GameObject Poema;
    // Start is called before the first frame update
    void Start()
    {
        Estrelas = GameObject.FindGameObjectsWithTag("Estrela");
        scene = SceneManager.GetActiveScene();
        if (scene.name == "Lobby 1"){
            if (PlayerPrefs.GetInt("Fase1") == 1 && PlayerPrefs.GetInt("Fase2") == 1 && PlayerPrefs.GetInt("Fase3") == 1 && PlayerPrefs.GetInt("Fase4") == 1 ){
                if (PlayerPrefs.GetInt("Chave") < 1){
                    Instantiate (Poema);
                }
            }
        }else 
        if (scene.name == "Lobby 2"){
            if (PlayerPrefs.GetInt("Fase5") == 1 && PlayerPrefs.GetInt("Fase6") == 1 && PlayerPrefs.GetInt("Fase7") == 1 && PlayerPrefs.GetInt("Fase8") == 1 ){
                if (PlayerPrefs.GetInt("Chave") < 2){
                    Instantiate (Poema);
                }
            }
        }else 
        if (scene.name == "Lobby 3"){
            if (PlayerPrefs.GetInt("Fase9") == 1 && PlayerPrefs.GetInt("Fase10") == 1 && PlayerPrefs.GetInt("Fase11") == 1 && PlayerPrefs.GetInt("Fase12") == 1 ){
                if (PlayerPrefs.GetInt("Chave") < 3){
                    Instantiate (Poema);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ContarEstrelas(){
        bool Completo  = true;
        foreach (GameObject star in Estrelas){
            if (star.GetComponent<Estrela>().ativado == false){
                Completo = false;
            }
        }
        if (Completo){
            Debug.Log("Fase Completa");
            PlayerPrefs.SetInt(scene.name,1);
        }
    }
}
