using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractiveObject : MonoBehaviour
{
    public bool IsInteractable { get; } = true;
    protected abstract void Interaction();

    private void Start()
    {
        Action();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!IsInteractable || !other.CompareTag("Player"))
        {
            return;
        }
        Interaction();
        Destroy(gameObject);
    }

    public void Action()
    {
        if (TryGetComponent(out Renderer renderer))
        {
            renderer.material.color = Random.ColorHSV();
        }
    }
}
