using UnityEngine;

public class BridgeBlockBehaviour : MonoBehaviour
{
    public Transform targetTransform;
    public bool active;
    private void Update()
    {
        if (!active) return;
        
        transform.position = Vector3.MoveTowards(transform.position, targetTransform.position, Time.deltaTime * 5f);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetTransform.rotation, Time.deltaTime * 5f);
    }
}
