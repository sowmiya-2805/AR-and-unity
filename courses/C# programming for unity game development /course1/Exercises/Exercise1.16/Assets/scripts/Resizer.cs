using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resizer : MonoBehaviour
{
    // timer support
    const float TotalResizeSeconds = 1; //determines the speed in which the ball grows
    float elapsedResizeSeconds = 0;

    //object scaling parameter
    const float ScaleFactorPerSecond = 1; // determines the scale by which the object grows
    int ScaleFactorSignMultiplier = -1; 

    // to resize the game object
    void Update()
    {
        Vector3 newscale = transform.localScale;
        newscale.x += ScaleFactorSignMultiplier * ScaleFactorPerSecond * Time.deltaTime ;
        newscale.y += ScaleFactorSignMultiplier * ScaleFactorPerSecond * Time.deltaTime ;
        transform.localScale = newscale;

        elapsedResizeSeconds += Time.deltaTime;
        if(elapsedResizeSeconds >= TotalResizeSeconds)
        {
            elapsedResizeSeconds = 0;
            ScaleFactorSignMultiplier *= -1; //reversing the direction alternates the action of the object to shrink and grow alternatively

        }
    }
}
