using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GoodBonus : InteractiveObject, IFlicker
{
    private Material _material;
    private List<InteractiveObject> _goodBonus = new List<InteractiveObject>();


    private void AddBonus(InteractiveObject bonus)
    {
        _goodBonus.Add(bonus);

    }

    private void Awake()
    {
        _material = GetComponent<Renderer>().material;
        
    }

    protected override void Interaction(GameObject other)
    {
        if (other.gameObject.TryGetComponent(out IHealthUp hpUp))
        {
            hpUp.HealthUp();
        }

        if (other.gameObject.TryGetComponent(out ISpeedUp speedUp))
        {
            speedUp.SpeedUp();
        }
    }

    public void Flicker()
    {
        _material.color = new Color(_material.color.r, _material.color.g, _material.color.b, Mathf.PingPong(Time.time, 1.0f));
    }

}
