using UnityEngine;

public sealed class GoodBonus : InteractiveObject, IFlicker
{
    [SerializeField] private bool IsSpeedUp = false;
    [SerializeField] private bool IsHealthUp = false;
    private Material _material;
    private DisplayBonuses _displayBonuses;


    private void Awake()
    {
        _material = GetComponent<Renderer>().material;
        _displayBonuses = GetComponent<DisplayBonuses>();
    }

    protected override void Interaction()  
    {
        _displayBonuses.Display(10);
    }

    public void Flicker()
    {
        _material.color = new Color(_material.color.r, _material.color.g, _material.color.b, Mathf.PingPong(Time.time, 1.0f));
    }

}
