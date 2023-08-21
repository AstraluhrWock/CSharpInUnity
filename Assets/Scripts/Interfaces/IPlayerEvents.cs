using UnityEngine.EventSystems;

public interface IPlayerEvents : IEventSystemHandler
{
    float PlayerDamaged(float currentHealth);
    float PlayerSpeed(float currentSpeed);
}
