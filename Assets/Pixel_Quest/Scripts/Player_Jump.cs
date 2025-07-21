using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Jump : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    public float jumpForce = 10f;
    
    // Capsule 
    public float CapsuleHeight = 0.25f;
    public float CapsuleRadius = 0.08f;

    // Ground Check
    public Transform feetCollider;
    public LayerMask groundMask;
    private bool _groundCheck;
    private bool waterCheck;
    public float fallForce = 2;
    private Vector2 _gravityVector;

    private void Start()
    {
        _gravityVector = new Vector2(0, Physics2D.gravity.y);
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private int GetGroundMask()
    {
        return groundMask;
    }

    private void Update()
    {
        _groundCheck = Physics2D.OverlapCapsule(feetCollider.position, new Vector2(CapsuleHeight, CapsuleRadius), CapsuleDirection2D.Horizontal, 0, groundMask);
        if (Input.GetKeyDown(KeyCode.Space)&& _groundCheck)
        {

 

                _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, jumpForce);
               
            
        }

    }
}
