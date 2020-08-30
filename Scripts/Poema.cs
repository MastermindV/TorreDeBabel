using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poema : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col){
         if (col.gameObject.tag == "Player"){
            int chave = PlayerPrefs.GetInt("Chave");
            PlayerPrefs.SetInt("Chave",chave + 1);
            Debug.Log("Agora a chave é " +PlayerPrefs.GetInt("Chave"));
            Destroy(this.gameObject);
        }
    }
}
