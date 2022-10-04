using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class BadBonus : InteractiveObject, IFlicker
{
    private Material _material;
    private List<InteractiveObject> _badBonus = new List<InteractiveObject>();

    private void AddBonus(InteractiveObject bonus)
    {
      _badBonus.Add(bonus);
    }

    private void Awake()
    {
        _material = GetComponent<Renderer>().material;
        
    }

    protected override void Interaction(GameObject other)
    {
        if (other.gameObject.TryGetComponent(out IHealthDown hpDown))
        {
            hpDown.HealthDown();
        }

        if (other.gameObject.TryGetComponent(out ISpeedDown speedDown))
        {
            speedDown.SpeedDown();
        }

    }

    public void Flicker()
    {
        _material.color = new Color(_material.color.r, _material.color.g, _material.color.b, Mathf.PingPong(Time.time, 1.0f));
    }

}
