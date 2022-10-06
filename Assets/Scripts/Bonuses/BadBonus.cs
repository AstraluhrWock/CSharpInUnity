using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class BadBonus : InteractiveObject, IFlicker
{
    [SerializeField] private bool isSpeedDown = false;
    [SerializeField] private bool isHealthDown = false;

    private Material _material;
    private Player _player;

   // private List<InteractiveObject> _badBonus = new List<InteractiveObject>();

    /*private void AddBonus(InteractiveObject bonus)
    {
      _badBonus.Add(bonus);
    }*/

    private void Awake()
    {
        _material = GetComponent<Renderer>().material;
        _player = FindObjectOfType<Player>();
        
    }

    protected override void Interaction()
    {

        /* if (other.gameObject.TryGetComponent(out IHealthDown hpDown))
         {
             hpDown.HealthDown();
         }

         if (other.gameObject.TryGetComponent(out ISpeedDown speedDown))
         {
             speedDown.SpeedDown();
         }*/
        if (isSpeedDown)
            _player.SpeedPoint = 2;
           

        if (isHealthDown)
            _player.HealthPoint = 75;
        
        
        

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
            // Destroy();
        }
    }

    public void Flicker()
    {
        _material.color = new Color(_material.color.r, _material.color.g, _material.color.b, Mathf.PingPong(Time.time, 1.0f));
    }



}
