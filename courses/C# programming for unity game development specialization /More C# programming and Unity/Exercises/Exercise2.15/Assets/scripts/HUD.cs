using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [SerializeField]
    Text Bouncetext;
    int bounces = 0;

    void Start()
    {
        Bouncetext.text = bounces.ToString();
    }
    public void AddBounce()
    {
        bounces += 10;
        Bouncetext.text = bounces.ToString();
    }

    
}
