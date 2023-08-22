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

    //private void Update()
    //{

    //    Invoke("Reload", 2f);


    //    if (_interactiveObjects.Count==0)
    //       //if (isWin==true)
    //            _gameWinPanel.SetActive(true);
    //}

    private void Reload()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Restart scene");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }


}
