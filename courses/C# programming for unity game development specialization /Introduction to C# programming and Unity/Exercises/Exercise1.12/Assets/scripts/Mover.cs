using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // To move the game object
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(-5, 0), ForceMode2D.Impulse);
    }

   
}
