using UnityEngine;

public class PowerUpScore : MonoBehaviour
{
    [SerializeField] int Layer = 7;
    [SerializeField] float delay = 10;
    [SerializeField] float speed = 3;
    static int powerUp = 1;
    static int DieBricks = 0;

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
    void PowerUpOn()
    {
        powerUp = 2;
    }
    void PowerUpOff()
    {
        powerUp = 1;
    }
    public static int PowerUpResult()
    {
        return powerUp;
    }
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
    void Direction()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - speed, transform.position.z);
    }
    public static void AddDieBricks()
    {
        DieBricks++;
    }
    public static void ResetDieBricks()
    {
        DieBricks = 0;
    }
    public static int ResultDieBricks()
    {
        return DieBricks;
    }
}
