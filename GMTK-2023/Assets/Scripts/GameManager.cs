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

    [SerializeField]
    public TextMeshPro ActionPointsScore;

    [SerializeField]
    private float _timeRemaining = 45f;
    private float _displayedTimeRemaining;

    void Update()
    {
        GameObject.Find("Action Points Remaining").GetComponent<TextMeshProUGUI>().text =
            $"Action Points Remaining {ActionPoints}";

        _timeRemaining -= Time.deltaTime;
        _displayedTimeRemaining = Mathf.RoundToInt(_timeRemaining);
        GameObject.Find("Time Remaining").GetComponent<TextMeshProUGUI>().text =
            $"Time Remaining: {_displayedTimeRemaining}";

        if (_timeRemaining <= 0f)
        {
            GameObject.Find("Win Screen").SetActive(true);
            GameObject.Find("Game Screen").SetActive(false);
        }
    }
}
