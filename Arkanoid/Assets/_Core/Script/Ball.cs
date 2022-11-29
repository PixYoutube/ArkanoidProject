using UnityEngine;

public class Ball : MonoBehaviour
{
    // Speed of ball
    [SerializeField] float ballSpeed;

    // Ball physics
    Vector3 lastVelocity;
    Rigidbody2D rb;

    #region Meth Unity
    private void Start()
    {
        if (rb) return;
        rb = GetComponent<Rigidbody2D>();

        rb.AddForce(new Vector2(20 * Time.deltaTime * ballSpeed, 20 * Time.deltaTime * ballSpeed));
    }
    private void Update()
    {
        // Adapte velocity of the ball
        lastVelocity = rb.velocity;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Bouncing the ball
        float speed = lastVelocity.magnitude;
        var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);
        rb.velocity = direction * Mathf.Max(speed, 0f);
    }
    #endregion
}
