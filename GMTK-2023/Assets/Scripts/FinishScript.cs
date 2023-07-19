using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScript : MonoBehaviour
{
    [SerializeField]
    private GameObject _loseScreen,
        _gameScreen;

    void OnTriggerEnter2D()
    {
        _loseScreen.SetActive(true);
        _gameScreen.SetActive(false);
    }
}
