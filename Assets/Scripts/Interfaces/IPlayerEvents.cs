using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public interface IPlayerEvents : IEventSystemHandler
{
    float PlayerDamaged(float currentHealth);
    float PlayerSpeed(float currentSpeed);
}
