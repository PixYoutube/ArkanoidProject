using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] GameObject parent;
    int Layers = 6;

    private void Update()
    {
        if(parent.transform.childCount == 0)
        {
            Player.Win();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == Layers)
        {
            Player.GameOver();
        }
    }
}
