using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    // jump location support
    const float minX = -10;
    const float maxX = 10;
    const float minY = -6.5f;
    const float maxY=6.5f;

    //timer support
    const float TotalJumpSeconds = 1;
    float ElapsedJumpDelaySeconds = 0;
    
    // Update timer and check if it's done
    void Update()
    {
        ElapsedJumpDelaySeconds += Time.deltaTime;
        if(ElapsedJumpDelaySeconds >= TotalJumpSeconds)
        {
            ElapsedJumpDelaySeconds -= TotalJumpSeconds; //subtracting both is more accurate than setting to zero
            transform.position = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0);
            
        }
    }
}
