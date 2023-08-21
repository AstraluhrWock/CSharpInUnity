using UnityEngine;
using TMPro;

public sealed class DisplayBonuses : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;

    public void Display(int value)
    {
        _text.text = $"Вы набрали {value}";
    }
}

