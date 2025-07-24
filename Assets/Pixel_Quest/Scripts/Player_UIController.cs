using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player_UIController : MonoBehaviour
{
    public Image heartImage; 

    // Start is called before the first frame update
    private void Start()
    {
        heartImage = GameObject.Find("HeartImage").GetComponent<Image>();
    }

    // Update is called once per frame
    public void UpdateHealth(float currentHealth, float maxHealth)
    {
        heartImage.fillAmount = currentHealth / maxHealth;
    }
        
    
        
    }

