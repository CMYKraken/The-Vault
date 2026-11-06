using UnityEngine;

public class BridgePlatformSegmentBehaviour : MonoBehaviour
{
    public Vector3 targetPosition;
    public Quaternion targetRotation;
    
    public bool active;
    private void Update()
    {
        if (!active) return;
        
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * 3f);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, 
            Time.deltaTime * 0.2f * Mathf.PI * Mathf.Rad2Deg);
    }
}
