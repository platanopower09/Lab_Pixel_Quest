using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Jump : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
   
    // Forces
    public float jumpForce = 10f;
    public float fallForce = 2;

    // Capsule 
    public float CapsuleHeight = 0.25f;
    public float CapsuleRadius = 0.08f;

    // Ground Check
    public Transform feetCollider;
    public LayerMask groundMask;
    private bool _groundCheck;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(_waterTag)) { _waterCheck = true; }
    }

    // Check if player left water

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(_waterTag)) { _waterCheck = false; }
    }
    // Water Check 

    private bool _waterCheck;
    private string _waterTag = "Water";
    
    private Vector2 _gravityVector;
    public Rigidbody2D rb;

   //Sets gravity vector and connects components
    private void Start()
    {
        _gravityVector = new Vector2(0f, Physics2D.gravity.y);
        
        _rigidbody2D = GetComponent<Rigidbody2D>();
       


    }



    private void Update()
    {
        _groundCheck = Physics2D.OverlapCapsule(feetCollider.position, new Vector2(CapsuleHeight, CapsuleRadius), CapsuleDirection2D.Horizontal, 0, groundMask);
        if (Input.GetKeyDown(KeyCode.Space) && (_groundCheck || _waterCheck))
              {



            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, jumpForce);
        }
            // Checks if the gravity should be getting faster 

            if (rb.velocity.y > 0 && !_waterCheck)
            {

            _rigidbody2D.velocity += _gravityVector * (fallForce * Time.deltaTime);
        }
        



    

               
            
       
       
    }
}
