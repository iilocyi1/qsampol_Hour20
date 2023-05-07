using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerZone : MonoBehaviour
{
    void OnTriggerEnter (Collider another)
    {
        Destroy(another.gameObject);
    }
}
