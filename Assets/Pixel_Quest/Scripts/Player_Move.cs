using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player_Move : MonoBehaviour
{
    private SpriteRenderer rbSprite;
    private Rigidbody2D _rigidbody2D;
    public int speed = 7;
    private SpriteRenderer sr1;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D Rigidbody2D = GetComponent<Rigidbody2D>();
        sr1 = GetComponentInChildren<SpriteRenderer>();
    }

    
        
     
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        _rigidbody2D.velocity = new Vector2(horizontal * speed, _rigidbody2D.velocity.y);

    }
}


// Update is called once per frame
    
