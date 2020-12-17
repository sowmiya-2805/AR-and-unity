using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintPercent : MonoBehaviour
{
    // to implement the typecast operations in appropriate calculations in console window of unity
    void Start()
    {
        const int MaxScore = 100;
        int score = 10;
        float percentage = ((float)score / MaxScore)*100;
        print(" The percentage is " + percentage + "%");

        
    }

    
}
