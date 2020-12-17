using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenball : MonoBehaviour
{
    // making the green ball 3 times taller
    void Start()
    {
        Vector3 newScale = transform.localScale;
        newScale.y *= 3;
        transform.localScale = newScale;
        
    }

    
}
