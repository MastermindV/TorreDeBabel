using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estrela : MonoBehaviour
{
    public bool ativado; 
    public GameObject GameController;
    public GameController Script;
    // Start is called before the first frame update
    void Start()
    {
        ativado = false;
        GameController = GameObject.FindGameObjectWithTag("GameController");
        Script = GameController.GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit2D(Collider2D col){
        if (col.gameObject.tag == "Caixa"){
            ativado = false;
        }
    }
    void OnTriggerStay2D(Collider2D col){
        if (col.gameObject.tag == "Caixa"){
            ativado = true;
            Script.ContarEstrelas();
        }
    }
}
