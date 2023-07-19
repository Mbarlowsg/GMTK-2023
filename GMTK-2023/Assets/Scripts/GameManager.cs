using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private static float _actionPoints = 7;
    public static float ActionPoints
    {
        get { return _actionPoints; }
        set { _actionPoints = value; }
    }
    private TextMeshProUGUI _actionPointsScore;

    [SerializeField]
    private float _timeRemaining = 45f;
    private TextMeshProUGUI _displayedTimeRemaining;

    [SerializeField]
    private GameObject _winScreen,
        _loseScreen,
        _gameScreen;

    void Start()
    {
        _actionPointsScore = GameObject
            .Find("Action Points Remaining")
            .GetComponent<TextMeshProUGUI>();

        _displayedTimeRemaining = GameObject.Find("Time Remaining").GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        _actionPointsScore.text = $"Action Points Remaining {ActionPoints}";

        _timeRemaining -= Time.deltaTime;
        _displayedTimeRemaining.text = $" Time Remaining: {Mathf.RoundToInt(_timeRemaining)}";

        if (_timeRemaining <= 0f)
        {
            _winScreen.SetActive(true);
            _gameScreen.SetActive(false);
        }
    }
}
