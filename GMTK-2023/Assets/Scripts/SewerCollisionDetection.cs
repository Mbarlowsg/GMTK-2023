using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class SewerCollisionDetection : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    float temp;

    [SerializeField]
    float delayTime;

    private void Awake()
    {
        temp = player.GetComponent<AIPath>().maxSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        player.GetComponent<AIPath>().maxSpeed = 0.5f;
        Test();
    }

    private void Test()
    {
        StartCoroutine(WaitForFunction());
    }

    IEnumerator WaitForFunction()
    {
        yield return new WaitForSeconds(delayTime);
        player.GetComponent<AIPath>().maxSpeed = temp;
    }
}
