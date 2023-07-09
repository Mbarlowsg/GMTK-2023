using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManholeTrap : MonoBehaviour
{
    [SerializeField]
    private GameObject _inactiveManhole;

    [SerializeField]
    private GameObject _activeManhole;

    [SerializeField]
    private GameObject _highlight;

    private float delayTime = 5f;

    private void OnMouseDown()
    {
        if (GameManager.ActionPoints >= 1)
        {
            _inactiveManhole.SetActive(false);
            _activeManhole.SetActive(true);
            GameManager.ActionPoints--;
        }
        // Test();
    }

    void OnMouseEnter()
    {
        _highlight.SetActive(true);
    }

    void OnMouseExit()
    {
        _highlight.SetActive(false);
    }

    // private void Test()
    // {
    //     StartCoroutine(WaitForFunction());
    // }

    // IEnumerator WaitForFunction()
    // {
    //     yield return new WaitForSeconds(delayTime);
    //     GameObject.Find("Manhole (active)").GetComponent<BoxCollider2D>().isTrigger = true;
    // }
}
