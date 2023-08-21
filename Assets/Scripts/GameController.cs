using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public sealed class GameController : MonoBehaviour
{
    [SerializeField] private GameObject _gameWinPanel;
    private List<InteractiveObject> _interactiveObjects;
    private bool isWin = false;

    private void Start()
    {
        _gameWinPanel.SetActive(false);
    }

    private void Awake()
    {
        _interactiveObjects = new List<InteractiveObject>();
        InteractiveObject[] sceneObjects = FindObjectsOfType<InteractiveObject>();  
        _interactiveObjects.AddRange(sceneObjects);      
    }
    

    private void Update()
    {
        for (int i = 0; i < _interactiveObjects.Count; i++)
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

            if (interactiveObject is ISpeedDown speedDown)
            {
                speedDown.SpeedDown();
            }

            Invoke("Reload", 2f);
        }

 
        if (_interactiveObjects.Count==0)
           //if (isWin==true)
                _gameWinPanel.SetActive(true);
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
