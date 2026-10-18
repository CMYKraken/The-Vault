using System;
using UnityEngine;
using UnityEngine.Serialization;

public class BridgeBlockBehaviour : MonoBehaviour
{
    public Transform targetTransform;
    public bool active;
    private void Update()
    {
        if (!active) return;
        
        transform.position = Vector3.MoveTowards(transform.position, targetTransform.position, Time.deltaTime * 5f);
    }
}
