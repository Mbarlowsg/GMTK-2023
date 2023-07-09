using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class IntersectionScript : MonoBehaviour
{
    [SerializeField]
    private GameObject _highlight;

    [SerializeField]
    private GameObject[] _blockades;

    private BoxCollider2D _collider;

    private float delayTime = 10f;

    // Start is called before the first frame update
    void Start()
    {
        _collider = GetComponent<BoxCollider2D>();

        _collider.isTrigger = true;
    }

    // Update is called once per frame
    void Update() { }

    void OnMouseEnter()
    {
        _highlight.SetActive(true);
    }

    void OnMouseExit()
    {
        _highlight.SetActive(false);
    }

    void OnMouseDown()
    {
        Click();
    }

    void Click()
    {
        if (GameManager.ActionPoints >= 1)
        {
            if (_collider.isTrigger == false)
            {
                _collider.isTrigger = true;
                _blockades[0].SetActive(false);
                _blockades[1].SetActive(false);
                _blockades[2].SetActive(false);
                _blockades[3].SetActive(false);
            }
            else
            {
                _collider.isTrigger = false;
                _blockades[0].SetActive(true);
                _blockades[1].SetActive(true);
                _blockades[2].SetActive(true);
                _blockades[3].SetActive(true);
            }
            var graphToScan = AstarPath.active.data.gridGraph;
            AstarPath.active.Scan(graphToScan);
            GameManager.ActionPoints--;
            print(GameManager.ActionPoints);
            Test();
        }
    }

    private void Test()
    {
        StartCoroutine(WaitForFunction());
    }

    IEnumerator WaitForFunction()
    {
        yield return new WaitForSeconds(delayTime);
        print("CLICK DONE");
        _collider.isTrigger = true;
        _blockades[0].SetActive(false);
        _blockades[1].SetActive(false);
        _blockades[2].SetActive(false);
        _blockades[3].SetActive(false);
        var graphToScan = AstarPath.active.data.gridGraph;
        AstarPath.active.Scan(graphToScan);
    }
}
