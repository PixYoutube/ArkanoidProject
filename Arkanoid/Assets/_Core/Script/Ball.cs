using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float ballSpeed;

    Vector3 lastVelocity;
    Rigidbody2D rb;
    private void Start()
    {
        if (rb) return;
        rb = GetComponent<Rigidbody2D>();

        rb.AddForce(new Vector2(20 * Time.deltaTime * ballSpeed, 20 * Time.deltaTime * ballSpeed));
    }
    private void Update()
    {
        lastVelocity = rb.velocity;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        float speed = lastVelocity.magnitude;
        var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);
        rb.velocity = direction * Mathf.Max(speed, 0f);
    }
}
