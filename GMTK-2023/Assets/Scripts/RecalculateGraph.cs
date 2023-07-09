using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class RecalculateGraph : MonoBehaviour
{
    // public AIPath path;

    // Start is called before the first frame update
    void Start()
    {
        // path.maxAcceleration = -2f;
        // InvokeRepeating("CheckPath", 0f, 3f);
    }

    // Update is called once per frame
    void FixedUpdate() { }

    void CheckPath()
    {
        var graphToScan = AstarPath.active.data.gridGraph;
        AstarPath.active.Scan(graphToScan);
    }
}
