/*
Art from https://kenney.nl
    Input Prompts - https://kenney.nl/assets/input-prompts
    Tiny Town - https://kenney.nl/assets/tiny-town
    Tiny Dungeon - https://kenney.nl/assets/tiny-dungeon
    Fantasy UI Borders - https://kenney.nl/assets/fantasy-ui-borders

Font from https://www.1001fonts.com/
    BlackChancery Font  - https://www.1001fonts.com/blackchancery-font.html
*/

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
         _rigidbody2D = GetComponent<Rigidbody2D>();
        sr1 = GetComponentInChildren<SpriteRenderer>();
    }

    
        
     
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        _rigidbody2D.velocity = new Vector2(horizontal * speed, _rigidbody2D.velocity.y);

    }
}


// Update is called once per frame


    
