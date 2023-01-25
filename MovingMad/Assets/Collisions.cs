using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    private void OnCollisionEnter2d(Collision2D collision)
    {
        if (collision.gameObject.name == "slime_sprite")
        {
            Debug.Log("you got hit");
        }
    }
} 
