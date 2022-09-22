using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPickUpBonus 
{
    public float SpeedUp(float currSpeed);
    public float HealthUp(float currHealth);
    public float SpeedDown(float currSpeed);
    public float HealthDown(float currHealth);

}
