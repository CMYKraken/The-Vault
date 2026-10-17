using System;
using UnityEngine;

public class BridgeBlockBehaviour : MonoBehaviour
{
    public Vector3 targetPosition;
    public bool active;
    private void Update()
    {
        if (!active) return;
        
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * 5f);
    }
}
