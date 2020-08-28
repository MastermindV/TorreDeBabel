using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estrela : MonoBehaviour
{
    public bool ativado; 
    // Start is called before the first frame update
    void Start()
    {
        ativado = false;
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
        }
    }
}
