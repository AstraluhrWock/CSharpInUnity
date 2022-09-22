using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Bonus : InteractiveObject, IFlicker
{
    private Material _material;
    private List<InteractiveObject> _goodBonus = new List<InteractiveObject>();
    private List<InteractiveObject> _badBonus = new List<InteractiveObject>();

    private void Awake()
    {
        _material = GetComponent<Renderer>().material;
        //_goodBonus.Add();
    }

    protected override void Interaction()
    { 
        // Add bonus
    }

    public void Flicker()
    {
        _material.color = new Color(_material.color.r, _material.color.g, _material.color.b, Mathf.PingPong(Time.time, 1.0f));
    }

}
