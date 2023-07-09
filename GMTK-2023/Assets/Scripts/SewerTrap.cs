using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SewerTrap : MonoBehaviour
{
    [SerializeField]
    private GameObject inactiveSewer;

    [SerializeField]
    private GameObject activeSewer;

    [SerializeField]
    private GameObject _highlight;

    private void OnMouseDown()
    {
        if (GameManager.ActionPoints >= 1)
        {
            inactiveSewer.SetActive(false);
            activeSewer.SetActive(true);
            GameManager.ActionPoints--;
        }
    }

    void OnMouseEnter()
    {
        _highlight.SetActive(true);
    }

    void OnMouseExit()
    {
        _highlight.SetActive(false);
    }
}
