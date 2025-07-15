using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Transactions;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GeoController : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer rbSprite;
   int varTwo = 3;
    public int fast = 7;
    private object groundCheck;
    private object isGrounded;
    private object position;
    private readonly object groundCheckRadius;
    public string NextLevel = "Scene_2";

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        int var2 = 2;
        rbSprite = GetComponent<SpriteRenderer>();

        

        
        
     
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
       //ebug.Log(xInput);
        rb.velocity = new Vector2(xInput * fast,  rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            rbSprite.color = Color.grey;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            rbSprite.color = Color.green; 
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            rbSprite.color = Color.yellow; 
        }

    } 
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel); 
                    break; 
                    
                }
            case "Next Level":
                {
                    SceneManager.LoadScene(NextLevel);
                    break;
                }
        }

    }
}
