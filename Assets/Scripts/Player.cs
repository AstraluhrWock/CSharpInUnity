using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health = 100;
    [SerializeField] private int _speed = 4;
    private Material _material;
    private Rigidbody _ball;
    private float _score;

    private CheckBonuses _checkBonuses;

    public Action<float> SpeedChanged;

    public int HealthPoint
    {
        get { return _health; }
        set { _health = value; }
    }

    public int SpeedPoint
    {
        get { return _speed; }
        set { _speed = value; }
    }

    public Material PlayerMaterial
    {
        get { return _material; }
        set { _material = value; }
    }

    public Player(int health, int speed)
    {
        _health = health;
        _speed = speed;
    }

    protected void SetData()
    {
        _ball = GetComponent<Rigidbody>();
        _checkBonuses = new CheckBonuses();     
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
        var interactiveObject = other.GetComponent<InteractiveObject>();
        _checkBonuses.Execute(interactiveObject);
        Destroy(other.gameObject);

    }

}
