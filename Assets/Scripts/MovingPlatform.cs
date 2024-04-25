using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        collider.transform.SetParent(transform);
    }

    private void OnTriggerExit(Collider collider)
    {
        collider.transform.SetParent(null);
    }
    
}
