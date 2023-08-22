using UnityEngine;

public sealed class BadBonus : InteractiveObject, IFlicker, IHealthDown, ISpeedDown
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
    public float HealthDown()
    {
        _player.HealthPoint -= 20;
        _display.Display(_player.HealthPoint, _player.SpeedPoint);
        if (_player.HealthPoint < 0 || _player.HealthPoint == 0)
        {
            Destroy(_player.gameObject);
        }
        return _player.HealthPoint;
    }

    public int SpeedDown()
    {
        _player.SpeedPoint -= 2;
        _display.Display(_player.HealthPoint, _player.SpeedPoint);
        if (_player.SpeedPoint == 0)
        {
            Destroy(_player.gameObject);
        }
        return _player.SpeedPoint;
    }
    public void Flicker()
    {
        _material.color = new Color(_material.color.r, _material.color.g, _material.color.b, Mathf.PingPong(Time.time, 1.0f));
    }
}
