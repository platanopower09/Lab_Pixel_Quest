using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Stats : MonoBehaviour
{
    public string NextLevel = "Scene_2";
    public int coinCount  = 0;
    public int _health = 3;
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
            case "Coin":
                {
                    coinCount++;
                    Destroy(collision.gameObject);
                    break;
                }
            case "Health":
                {
                    _health++;
                    Destroy(collision.gameObject);
                    break;
                }


           
        }

    }




}
    
  

