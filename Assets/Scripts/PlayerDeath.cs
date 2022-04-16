using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{   
    public GameOverScreen gameover;
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.CompareTag("Engel"))
        {
           
            Destroy(gameObject);

            Time.timeScale = 0f;
            gameover.Setup();
        }
    }     
}