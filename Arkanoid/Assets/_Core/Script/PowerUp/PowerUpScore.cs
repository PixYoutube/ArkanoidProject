using UnityEngine;

public class PowerUpScore : MonoBehaviour
{
    #region Settings
    // Set number of layer
    [SerializeField] int Layer = 7;
    [SerializeField] float delay = 10;
    [SerializeField] float speed = 3;

    static int powerUp = 1;
    static int DieBricks = 0;
    #endregion

    #region Meths Unity
    private void Update()
    {
        Direction();
        CounterPowerUp();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == Layer)
        {
            PowerUpOn();
            Destroy(gameObject);
        }
    }
    #endregion
    #region Meths
    #region On or Off
    void PowerUpOn()
    {
        powerUp = 2;
    }
    void PowerUpOff()
    {
        powerUp = 1;
    }
    #endregion
    #region Delay
    void CounterPowerUp()
    {
        if(powerUp == 2) {
            float _counter = 0;
            _counter += Time.deltaTime;
            if(_counter < delay)
            {
                PowerUpOff();
            }
        }
    }
    #endregion
    #region PowerUp direction
    void Direction()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - speed, transform.position.z);
    }
    #endregion
    #region Add and reset Die of the brics
    public static void AddDieBricks()
    {
        DieBricks++;
    }
    public static void ResetDieBricks()
    {
        DieBricks = 0;
    }
    #endregion
    #region Result PowerUp
    public static int PowerUpResult()
    {
        return powerUp;
    }
    public static int ResultDieBricks()
    {
        return DieBricks;
    }
    #endregion
    #endregion
}
