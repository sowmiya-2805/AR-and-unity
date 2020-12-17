using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    // to move the ball to right
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(6,0), ForceMode2D.Impulse);
    }

    
}
