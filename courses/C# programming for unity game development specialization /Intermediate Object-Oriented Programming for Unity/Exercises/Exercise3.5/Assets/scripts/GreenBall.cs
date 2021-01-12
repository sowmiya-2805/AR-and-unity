using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//make GreenBall as the child class of the Ball class
public class GreenBall : Ball
{
    
    override protected void Start()
    {
        impulseVector = new Vector2(0, 5);
        base.Start();
    }

    override protected void PrintMessage()
    {
        print("I'm a green ball");
    }
}
