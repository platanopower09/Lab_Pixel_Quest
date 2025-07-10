using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;
using UnityEngine.UIElements;

public class GeoController : MonoBehaviour
{
    private Rigidbody2D rb;
   int varTwo = 3; 
    public int speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        int var2 = 2;
        Debug.Log("Hello World");
        string milk = "what?";
        
     
    }

    // Update is called once per frame
    void Update()


    {
        float xInput = Input.GetAxis("Horizontal");
        Debug.Log(xInput);
        rb.velocity = new Vector2(xInput * speed,  rb.velocity.y); 

        /*
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3(0, 1, 0);
        }

        if (Input.GetKeyDown(KeyCode.A)) {
            transform.position += new Vector3(-1, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.S)) { 
        transform.position += new Vector3(0, -1, 0); }
        
    }*/
        OnCollisionEnter2D(Collision2D collision) 
    }
}

internal class rb
{
    private int v;
    private Vector2 velocity;

    public rb(int v, Vector2 velocity)
    {
        this.v = v;
        this.velocity = velocity;
    }
}