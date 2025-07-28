using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Player_UIController : MonoBehaviour
{
    public Image heartImage;
    public TextMeshPro text;
    public TextMeshPro uiText;
    public TextMeshProUGUI coinText;



    // Start is called before the first frame update
    public void StartUI()
    {
        heartImage = GameObject.Find("HeartImage").GetComponent<Image>();
        coinText = GameObject.Find("CoinText").GetComponent <TextMeshProUGUI>();
    }

    // Update is called once per frame
    public void UpdateHealth(float currentHealth, float maxHealth)
    {
        heartImage.fillAmount = currentHealth / maxHealth;
    }
        
    public void UpdateText(string newText)
    {
        coinText.text = newText;
    }

        
    }





