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
        Debug.Log(PlayerPrefs.GetInt("Chave"));
        Estrelas = GameObject.FindGameObjectsWithTag("Estrela");
        scene = SceneManager.GetActiveScene();
        if (scene.name == "Lobby 1"){
            if (PlayerPrefs.GetInt("Fase 1") == 1 && PlayerPrefs.GetInt("Fase 2") == 1 && PlayerPrefs.GetInt("Fase 3") == 1 && PlayerPrefs.GetInt("Fase 4") == 1 ){
                if (PlayerPrefs.GetInt("Chave") < 1){
                    Instantiate (Poema);
                }
            }
        }else 
        if (scene.name == "Lobby 2"){
            if (PlayerPrefs.GetInt("Fase 5") == 1 && PlayerPrefs.GetInt("Fase 6") == 1 && PlayerPrefs.GetInt("Fase 7") == 1 && PlayerPrefs.GetInt("Fase 8") == 1 ){
                if (PlayerPrefs.GetInt("Chave") < 2){
                    Instantiate (Poema);
                }
            }
        }else 
        if (scene.name == "Lobby 3"){
            if (PlayerPrefs.GetInt("Fase 9") == 1 && PlayerPrefs.GetInt("Fase 10") == 1 && PlayerPrefs.GetInt("Fase 11") == 1 && PlayerPrefs.GetInt("Fase 12") == 1 ){
                if (PlayerPrefs.GetInt("Chave") < 3){
                    Instantiate (Poema);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C)){
            Debug.Log(PlayerPrefs.GetInt("Chave"));
            Debug.Log(PlayerPrefs.GetInt("Fase 1"));
            Debug.Log(PlayerPrefs.GetInt("Fase 2"));
            Debug.Log(PlayerPrefs.GetInt("Fase 3"));
            Debug.Log(PlayerPrefs.GetInt("Fase 4"));
        }
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
