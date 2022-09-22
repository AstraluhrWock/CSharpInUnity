using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private InteractiveObject[] _interactiveObjects;

    public static GameController current;

    private void Awake()
    {
        current = this;
        //_interactiveObjects = FindObjectOfType<InteractiveObject>();
    }
    public event Action onHealthTriggerEnter;
    public void HealthTriggerEnter()
    {
        if (onHealthTriggerEnter != null)
        {
            onHealthTriggerEnter();
        }
    }


    //private void Update()
    //{
    //    for (var i = 0; i < _interactiveObjects.Length; i++)
    //    {
    //        var interactiveObject = _interactiveObjects[i];

    //        if (interactiveObject == null)
    //        {
    //            continue;
    //        }

    //        if (interactiveObject is IFlicker flicker)
    //        {
    //            flicker.Flicker();
    //        }
    //    }
    //}
}
