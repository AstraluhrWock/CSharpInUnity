using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GoodBonus : InteractiveObject, IFlicker
{
    [SerializeField] private bool IsSpeedUp = false;
    [SerializeField] private bool IsHealthUp = false;
    private Material _material;
    private Player _player;
   // private List<InteractiveObject> _goodBonus = new List<InteractiveObject>();


   /* private void AddBonus(InteractiveObject bonus)
    {
        _goodBonus.Add(bonus);

    }*/

    private void Awake()
    {
        _material = GetComponent<Renderer>().material;
        _player = FindObjectOfType<Player>();

    }

    protected override void Interaction()  // GameObject other
    {
        /* if (other.gameObject.TryGetComponent(out IHealthUp hpUp))
         {
             hpUp.HealthUp();
         }

         if (other.gameObject.TryGetComponent(out ISpeedUp speedUp))
         {
             speedUp.SpeedUp();
         }*/
        if (IsSpeedUp)
            _player.SpeedPoint = 5;

        if (IsHealthUp)
            _player.HealthPoint = 120;
    }

    public void Flicker()
    {
        _material.color = new Color(_material.color.r, _material.color.g, _material.color.b, Mathf.PingPong(Time.time, 1.0f));
    }

}
