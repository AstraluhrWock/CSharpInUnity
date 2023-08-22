public class PlayerBall : Player
{
    public PlayerBall(int health, int speed) : base(health, speed)
    { 
    
    }
    private void Awake()
    {
        SetData();
    }
    private void FixedUpdate()
    {
        Move();
    }
}
