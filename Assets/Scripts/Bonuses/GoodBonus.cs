using UnityEngine;

public sealed class GoodBonus : InteractiveObject, IFlicker, IHealthUp, ISpeedUp
{
    private Material _material; 
    private PlayerBall _player;
    private DisplayPlayerParam _display;


    private void Awake()
    {
        _material = GetComponent<Renderer>().material; 
        _player = FindObjectOfType<PlayerBall>();
        _display = FindObjectOfType<DisplayPlayerParam>();
    }

    protected override void Interaction()  
    {
       
    }

    public void Flicker()
    {
        _material.color = new Color(_material.color.r, _material.color.g, _material.color.b, Mathf.PingPong(Time.time, 1.0f));
    }

    public int HealthUp()
    {
        _player.HealthPoint += 20;
        _display.Display(_player.HealthPoint, _player.SpeedPoint);
        Debug.Log($"Health up {_player.HealthPoint}");
        return _player.HealthPoint;
    }

    public float SpeedUp()
    {
        _player.SpeedPoint += 2;
        _display.Display(_player.HealthPoint, _player.SpeedPoint);
        Debug.Log($"Speed {_player.SpeedPoint}");
        return _player.SpeedPoint;
    }

}
