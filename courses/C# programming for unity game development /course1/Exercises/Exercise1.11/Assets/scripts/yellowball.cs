using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellowball : MonoBehaviour
{
    
    void Start()
    {
        //to access the location of the object
        Vector3 newScale = transform.localScale;
        newScale.x *= 4;
        newScale.y *= 4;
        transform.localScale = newScale;

    }

}
