using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody _ball;
    private float _health;
    private float _score;
    // private float List<Item>
    //enum Item { pharmacy, bonus, speedUp }

    public int speed = 2;

   /* public Player(float health)
    {
        _health = health;
    }*/

    // get set health

    // damage get set

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
