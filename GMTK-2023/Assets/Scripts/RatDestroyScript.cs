using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatDestroyScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D rat)
    {
        print("Collision");
        Destroy(rat);
    }
}
