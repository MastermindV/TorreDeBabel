using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("BaixoEsquerda", false);
        animator.SetBool("BaixoDireita", false);
        animator.SetBool("CimaEsquerda", false);
        animator.SetBool("CimaDireita", false);
        rb.velocity = new Vector3(0, 0, 0);
        

        if (Input.GetKey(KeyCode.W)){
            rb.velocity = new Vector2(rb.velocity.x, speed);
            animator.SetBool("CimaDireita", true);
        }
        if (Input.GetKey(KeyCode.W) && (Input.GetKey(KeyCode.D)))
        {
            rb.velocity = new Vector2(rb.velocity.x, speed);
            animator.SetBool("CimaDireita", true);
        }
        
        if (Input.GetKey(KeyCode.W) && (Input.GetKey(KeyCode.A)))
        {
            rb.velocity = new Vector2(rb.velocity.x, speed);
            animator.SetBool("CimaEsquerda", true);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(rb.velocity.x, -speed);
            animator.SetBool("BaixoEsquerda", true);
        }
        if (Input.GetKey(KeyCode.S)&&(Input.GetKey(KeyCode.D)))
        {
            rb.velocity = new Vector2(rb.velocity.x, -speed);
            animator.SetBool("BaixoDireita", true);
        }
        if (Input.GetKey(KeyCode.S) && (Input.GetKey(KeyCode.A)))
        {
            rb.velocity = new Vector2(rb.velocity.x, -speed);
            animator.SetBool("BaixoEsquerda", true);
        }
        if (Input.GetKey(KeyCode.D)){
            rb.velocity = new Vector2(speed,rb.velocity.y);
            animator.SetBool("BaixoDireita", true);

        }
        if (Input.GetKey(KeyCode.A)){
            rb.velocity = new Vector2(-speed,rb.velocity.y);
            animator.SetBool("BaixoEsquerda", true);
        }

    }
}
