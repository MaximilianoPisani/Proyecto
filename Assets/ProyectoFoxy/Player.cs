using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
     public float speed = 5f; public float jumpForce = 10f; private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }    


    void Update()
    {

        { 
            // Movimiento horizontal
            float moveInput = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2 (moveInput * speed, rb.velocity.y);
        }
        // Salto
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        
        }

        if (Input.GetKeyDown(KeyCode.S))
        { 
          Debug.Log("Foxy lay down ");
        }
     
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Foxy is moving an object ");
        }
       
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Debug.Log("Foxy is running ");
        }
    }
}
