using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }

    void OnTriggerEnter2D()
    {
        GameObject.Find("Lose Screen").SetActive(true);
        GameObject.Find("Game Screen").SetActive(false);
    }
}
