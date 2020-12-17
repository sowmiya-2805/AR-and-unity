using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redball : MonoBehaviour
{
    //making the red ball 3 times wide
    void Start()
    {
        Vector3 newScale = transform.localScale;
        newScale.x *= 3;
        transform.localScale = newScale;
        
    }

    
}
