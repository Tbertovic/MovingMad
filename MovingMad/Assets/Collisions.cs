using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public bool hit = false;
    public GameManagerScript gameManager;
    private void OnCollisionEnter2d(Collision2D collision)
    {
        if (collision.gameObject.name == "slime_sprite" && hit == false)
        {
            //gameManager.gameOver();
            Debug.Log("you got hit");
            hit = true;
        }
    }
} 
