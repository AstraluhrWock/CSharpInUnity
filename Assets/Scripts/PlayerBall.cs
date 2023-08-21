public class PlayerBall : Player
{
    public PlayerBall(float health) : base(health)
    { 
    
    }
    private void Awake()
    {
        SetRigidbody();
    }
    private void FixedUpdate()
    {
        Move();
    }
}
