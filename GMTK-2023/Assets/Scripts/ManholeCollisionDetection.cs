using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class ManholeCollisionDetection : MonoBehaviour
{
    [SerializeField]
    private GameObject _player;
    float _tempSpeed;

    [SerializeField]
    float delayTime;

    private void Awake()
    {
        _tempSpeed = _player.GetComponent<AIPath>().maxSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("collided");
        _player.GetComponent<AIPath>().maxSpeed = 0f;
        Test();
        print("exit collision");
    }

    private void Test()
    {
        StartCoroutine(WaitForFunction());
    }

    IEnumerator WaitForFunction()
    {
        yield return new WaitForSeconds(delayTime);
        _player.GetComponent<AIPath>().maxSpeed = _tempSpeed;
        GetComponent<BoxCollider2D>().isTrigger = false;
    }
}
