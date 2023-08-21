using UnityEngine;

public sealed class BadBonus : InteractiveObject, IFlicker
{
    [SerializeField] private bool isSpeedDown = false;
    [SerializeField] private bool isHealthDown = false;

    private Material _material;
    private Player _player;

    private void Awake()
    {
        _material = GetComponent<Renderer>().material;
        _player = FindObjectOfType<Player>();
    }

    protected override void Interaction()
    {

    }

    public void Start()
    {
        Subscribe();
    }

    public void Subscribe()
    {
        _player.AddSpeedListener(SpeedChanged);
    }

    private void SpeedChanged(float currSpeed)
    {
        if (currSpeed == 0)
        { 
            Destroy(this.gameObject);
        }
    }

    public void Flicker()
    {
        _material.color = new Color(_material.color.r, _material.color.g, _material.color.b, Mathf.PingPong(Time.time, 1.0f));
    }



}
