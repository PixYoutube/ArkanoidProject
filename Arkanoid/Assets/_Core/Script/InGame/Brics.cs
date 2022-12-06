using UnityEngine;

public class Brics : MonoBehaviour
{
    [SerializeField] float PV;
    [SerializeField] int pts;
    [SerializeField] GameObject powerUpScore;
    [SerializeField] GameObject powerUpDamage;

    // Define Layers number
    int Layers = 6;

    #region Meth Unity
    private void Update()
    {
        SpawnPowerUp();
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
            PV -= 1 * PowerUpDamage.PowerUpResult();
        }
    }
    #endregion
    #region Meth
    void Die()
    {
        // Add points and destroy Brick
        Scores.AddPoints(pts, PowerUpScore.PowerUpResult());
        Destroy(this.gameObject);
        PowerUpScore.AddDieBricks();
        PowerUpDamage.AddDieBricks();
    }
    void SpawnPowerUp()
    {
        if (PowerUpScore.ResultDieBricks() == 5)
        {
            GameObject instance = Instantiate(powerUpScore);
            instance.transform.position = transform.position;
            PowerUpScore.ResetDieBricks();
        } else if(PowerUpDamage.ResultDieBricks() == 10)
        {
            GameObject instance = Instantiate(powerUpDamage);
            instance.transform.position = transform.position;
            PowerUpDamage.ResetDieBricks();
        }
    }
    #endregion
}
