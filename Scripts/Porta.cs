using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Porta : MonoBehaviour
{
    public string Destino;
    public int Chave;
    public GameObject Natalia;
    public Moviment NataliaScript;
    SpriteRenderer Sprite;
    // Start is called before the first frame update
    void Start()
    {
        Natalia = GameObject.FindGameObjectWithTag("Player");
        NataliaScript = Natalia.GetComponent<Moviment>();
        Sprite = GetComponent<SpriteRenderer>();
        if ((PlayerPrefs.GetInt(Destino) > 0)){
            Debug.Log(Destino +PlayerPrefs.GetInt(Destino));
            Sprite.color = new Color (0, 0, 1, 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col){
        if (PlayerPrefs.GetInt("Chave") >= Chave){
            SceneManager.LoadScene(Destino);
        }
    }
}
