using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Stats : MonoBehaviour
{
    public string NextLevel = "Scene_2";
    public int coinCount  = 0;
    public int _health = 3;
    public Transform respawnPoint;
    public int _maxHealth = 3;
    private Player_UIController _player_UIController;

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        _player_UIController = GetComponent<Player_UIController>();
        _player_UIController.UpdateHealth(_health, _maxHealth);
            
        switch (collision.tag)
        {
            case "Death":
                {


                    _health--;
                    _player_UIController.UpdateHealth(_health, _maxHealth);
                    if (_health <=0)
                    {
                        string thisLevel = SceneManager.GetActiveScene().name;
                        SceneManager.LoadScene(thisLevel);
                       

                    }
                    else
                    {
                        transform.position = respawnPoint.position;
                    }
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
                    if (_health <= 3)
                    {
                        _health++;
                        _player_UIController.UpdateHealth(_health, _maxHealth);
                        Destroy(collision.gameObject);
                    }
                    break;
                    
                }
            case "Respawn":
                {
                    respawnPoint.position = collision.transform.Find("Point").position;
                    break;
                }
            case "Finish":
                {
                    string nextLevel = collision.transform.GetComponent<LevelGoal>().nextLevel;
                    SceneManager.LoadScene(nextLevel);
                    break;
                }


           
        }

    }




}
    
  

