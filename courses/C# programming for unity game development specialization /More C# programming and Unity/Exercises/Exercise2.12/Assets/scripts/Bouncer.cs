using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    int health = 100;
  
    // moving the object
    void Start()
    {
        const float MinImpulseForce = 3f;
        const float MaxImpulseForce = 5f;
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);

        GetComponent<Rigidbody2D>().AddForce(direction * magnitude, ForceMode2D.Impulse);

        print("Initial health - " + health);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(health > 0)
        {
            health -= 10;
            Color color = GetComponent<SpriteRenderer>().color;
            color.a -= 0.1f;
            GetComponent<SpriteRenderer>().color = color;
            print("Current health status - " + health);
        }
        else
        {
            Destroy(gameObject);
            print("health - " + health + ". Therefore, object destroyed");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
