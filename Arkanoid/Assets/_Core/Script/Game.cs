using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    int Layers = 6;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == Layers)
        {
            Player.GameOver();
        }
    }
}
