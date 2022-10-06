using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour, IHealthUp, IHealthDown, ISpeedUp, ISpeedDown
{
    private Rigidbody _ball;
    [SerializeField] private float _health = 100;
    private float _score;
  

    public Action<float> SpeedChanged;

    public int speed = 4;

    public float HealthPoint
    {
        get { return _health; }
        set { _health = value; }
    }

    public int SpeedPoint
    {
        get { return speed; }
        set { speed = value; }
    }

    public Player(float health)
    {
        _health = health;
    }

    public float SpeedUp() //(float currSpeed)
    {
        return speed + 2; // return currSpeed + 2;
    }

    public float HealthUp()
    {
        return _health + 20;
    }
    public float SpeedDown()
    { 
        Debug.Log("Speed down");
        SpeedChanged?.Invoke(speed);
        return speed - 2;
        
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


    void Start()
    {
        _ball = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
     {
        float rotationX = Input.GetAxisRaw("Horizontal");
        float rotationZ = Input.GetAxisRaw("Vertical");
        Vector3 moveBall = new Vector3(rotationX, 0.0f , rotationZ);
        _ball.AddForce(moveBall * speed);
     }



}
