using UnityEngine;

public class Brics : MonoBehaviour
{
    #region Settings
    // Set brics settings
    [SerializeField] float PV;
    [SerializeField] int pts;
    // Set Prefabs Power up
    [SerializeField] GameObject powerUpScore;
    [SerializeField] int spawnDelayScore = 5;
    [SerializeField] GameObject powerUpDamage;
    [SerializeField] int spawnDelayDamage = 10;

    // Define Layers number
    int Layers = 6;
    #endregion

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
        if (PowerUpScore.ResultDieBricks() == spawnDelayScore)
        {
            GameObject instance = Instantiate(powerUpScore);
            instance.transform.position = transform.position;
            PowerUpScore.ResetDieBricks();
        } else if(PowerUpDamage.ResultDieBricks() == spawnDelayDamage)
        {
            GameObject instance = Instantiate(powerUpDamage);
            instance.transform.position = transform.position;
            PowerUpDamage.ResetDieBricks();
        }
    }
    #endregion
}
