using UnityEngine;
using System;

public class Player : MonoBehaviour, IHealthUp, IHealthDown, ISpeedUp, ISpeedDown
{
    [SerializeField] private float _health = 100;
    [SerializeField] private int _speed = 4;
    private Rigidbody _ball;
    private float _score;

    public Action<float> SpeedChanged;

    public float HealthPoint
    {
        get { return _health; }
        set { _health = value; }
    }

    public int SpeedPoint
    {
        get { return _speed; }
        set { _speed = value; }
    }

    public Player(float health)
    {
        _health = health;
    }

    protected void SetRigidbody()
    {
        _ball = GetComponent<Rigidbody>();
    }

    public float SpeedUp() 
    {
        return _speed + 2;
    }

    public float HealthUp()
    {
        return _health + 20;
    }
    public float SpeedDown()
    { 
        Debug.Log("Speed down");
        SpeedChanged?.Invoke(_speed);
        return _speed - 2;
        
    }
    public float HealthDown()
    {
        if (_health < 0 || _health == 0)
        {
            Destroy(_ball);
        }
        return _health - 20;
    }

    public void AddSpeedListener(Action<float> speedChanged)
    {
        SpeedChanged += speedChanged;
    }

    public void RemoveSpeedListener(Action<float> speedChanged)
    {
        SpeedChanged -= speedChanged;
    }

    protected void Move()
     {
        float rotationX = Input.GetAxisRaw("Horizontal");
        float rotationZ = Input.GetAxisRaw("Vertical");
        Vector3 moveBall = new Vector3(rotationX, 0.0f , rotationZ);
        _ball.AddForce(moveBall * _speed);
     }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }

}
