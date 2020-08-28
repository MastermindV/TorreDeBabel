﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
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
        if (Input.GetKey(KeyCode.W)){
            rb.velocity = new Vector2(rb.velocity.x, speed);
        }
        if (Input.GetKey(KeyCode.S)){
            rb.velocity = new Vector2(rb.velocity.x, -speed);
        }
        if (Input.GetKey(KeyCode.D)){
            rb.velocity = new Vector2(speed,rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.A)){
            rb.velocity = new Vector2(-speed,rb.velocity.y);
        }
    }
}
