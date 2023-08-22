using TMPro;
using UnityEngine;
public class DisplayPlayerParam : MonoBehaviour
{
    [SerializeField] private TMP_Text _health;
    [SerializeField] private TMP_Text _speed;

    public void Display(int health, int speed)
    {
        _health.text = "Health: "+ health.ToString();
        _speed.text = "Speed: " + speed.ToString();
    }
}
