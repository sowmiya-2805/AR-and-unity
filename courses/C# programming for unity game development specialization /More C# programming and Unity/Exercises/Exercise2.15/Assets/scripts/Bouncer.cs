using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    HUD hud;

    void Start()
    {
        GameObject hudgameObject = GameObject.FindGameObjectWithTag("HUD");
        hud = hudgameObject.GetComponent<HUD>();

        const float MinImpulseForce = 3f;
        const float MaxImpulseForce = 5f;
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);

        GetComponent<Rigidbody2D>().AddForce(direction * magnitude, ForceMode2D.Impulse);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        hud.AddBounce();
    }
}
