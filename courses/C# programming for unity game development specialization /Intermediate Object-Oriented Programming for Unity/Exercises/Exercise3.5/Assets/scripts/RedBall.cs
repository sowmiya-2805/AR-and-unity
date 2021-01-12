using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBall : Ball
{
    
    override protected void Start()
    {
        impulseVector = new Vector2(5, 0);
        base.Start();
    }

    protected override void PrintMessage()
    {
        print("I'm a red ball");
    }
}
