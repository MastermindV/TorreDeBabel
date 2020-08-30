﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caixa : MonoBehaviour
{
     Rigidbody2D rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
         rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(0, 0, 0);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player"){
            Debug.Log("A");
        }
    }
}