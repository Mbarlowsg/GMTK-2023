using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatSpawner : MonoBehaviour
{
    [SerializeField]
    private Transform _targetLeft,
        _targetRight;

    [SerializeField]
    private GameObject _rat;

    [SerializeField]
    private float _spawnRate = 1;

    private float _spawnTimer = 0f;

    [SerializeField]
    private static float _playTime = 3f;
    public static float PlayTime
    {
        get { return _playTime; }
        set { _playTime = value; }
    }
    private static float _totalTime = 0f;
    public static float TotalTime
    {
        get { return _totalTime; }
        set { _totalTime = value; }
    }

    private static string _target;
    public static string Target
    {
        get { return _target; }
        set { _target = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        _target = "left";
        GameObject.Instantiate(_rat, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (_totalTime <= _playTime)
        {
            if (_spawnTimer >= _spawnRate)
            {
                GameObject.Instantiate(_rat, transform.position, Quaternion.identity);
                if (_target == "left")
                {
                    _target = "right";
                }
                else if (_target == "right")
                {
                    _target = "left";
                }
                _spawnTimer = 0;
            }
            else
            {
                _spawnTimer += Time.deltaTime;
            }
            _totalTime += Time.deltaTime;
        }
    }
}
