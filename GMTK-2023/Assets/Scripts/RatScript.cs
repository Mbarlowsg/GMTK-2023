using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatScript : MonoBehaviour
{
    [SerializeField]
    private string _target;

    [SerializeField]
    private float _moveSpeed = 2;

    [SerializeField]
    private GameObject _ratSpawner;

    [SerializeField]
    private Animator anim;

    [SerializeField]
    private GameObject _inactiveManhole;

    [SerializeField]
    private GameObject _activeManhole;

    private float move;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("Rat Move");
        if (RatSpawner.Target == "left")
        {
            _target = "left";
            transform.Rotate(0.0f, 0.0f, 45.0f, Space.Self);
            print("spawned rat left");
        }
        else if (RatSpawner.Target == "right")
        {
            _target = "right";
            transform.Rotate(0.0f, 0.0f, -135.0f, Space.Self);
            print("spawned rat left");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (RatSpawner.TotalTime <= RatSpawner.PlayTime)
        {
            if (_target == "left")
            {
                move = -1;
                transform.position += new Vector3(move, 0f, 0f) * _moveSpeed * Time.deltaTime;
            }
            else if (_target == "right")
            {
                move = 1;
                transform.position += new Vector3(move, 0f, 0f) * _moveSpeed * Time.deltaTime;
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
