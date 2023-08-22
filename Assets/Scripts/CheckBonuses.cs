using UnityEngine;
public class CheckBonuses
{
    public void Execute(InteractiveObject interactiveObject)
    {
        if (interactiveObject == null)
        {
            return;
        }

        if (interactiveObject is IFlicker flicker)
        {
            flicker.Flicker();
        }

        if (interactiveObject is IHealthUp healthUp)
        {
            healthUp.HealthUp();
        }

        if (interactiveObject is IHealthDown healthDown)
        {
            healthDown.HealthDown();
        }

        if (interactiveObject is ISpeedUp speedUp)
        {
            speedUp.SpeedUp();
        }

        if (interactiveObject is ISpeedDown speedDown)
        {
            speedDown.SpeedDown();
        }     
    }
}

