using UnityEngine;

public class Brics1 : MonoBehaviour
{
    [SerializeField] float PV;
    [SerializeField] int pts;
    int Layers = 6;

    #region Meth Unity
    private void Update()
    {
        // Verif life
        if(PV <= 0)
        {
            Die();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Damage
        if(collision.gameObject.layer == Layers)
        {
            PV -= 1;
        }
    }
    #endregion
    #region Meth
    void Die()
    {
        // Add points and destroy Brick
        Player.AddPoints(pts);
        GameObject.Destroy(this.gameObject);
    }
    #endregion
}
