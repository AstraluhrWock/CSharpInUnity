using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.UI;

public sealed class GameController : MonoBehaviour
{
    [SerializeField] private GameObject gameWinPanel;
    private InteractiveObject[] _interactiveObjects;
    private bool isWin = false;

    private void Start()
    {
       // gameWinPanel.SetActive(false);
    }

    private void Awake()
    {
        _interactiveObjects = FindObjectsOfType<InteractiveObject>();
    }
    

    private void Update()
    {
        for (var i = 0; i < _interactiveObjects.Length; i++)
        {
            var interactiveObject = _interactiveObjects[i];

            if (interactiveObject == null)
            {
                continue;
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

            /*if (interactiveObject is ISpeedDown speedDown)
            {
                speedDown.SpeedDown();
            }*/

            Invoke("Reload", 2f);
        }

        /*if (_interactiveObjects.Length) // при подборе всех бонусов
            if (isWin)
                gameWinPanel.SetActive(true);*/
    }

    private void Reload()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Restart scene");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }


}
