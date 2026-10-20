using UnityEngine;

public class BridgePlatform : MonoBehaviour
{
    public BridgeBlockBehaviour[] segments;
    public Quaternion[] rotations =  new Quaternion[4];
    private void Awake()
    {
        rotations[0] = transform.rotation;
        rotations[1] = Quaternion.Euler(transform.rotation.eulerAngles + Quaternion.AngleAxis(90, Vector3.up).eulerAngles);
        rotations[2] = Quaternion.Euler(transform.rotation.eulerAngles + Quaternion.AngleAxis(180, Vector3.up).eulerAngles);
        rotations[3] = Quaternion.Euler(transform.rotation.eulerAngles + Quaternion.AngleAxis(270, Vector3.up).eulerAngles);
    }

    public void AddSegment(BridgeBlockBehaviour segment)
    {
        segments[^1] = segment;
        segment.targetTransform.rotation = rotations[segments.Length - 1];
    }
}
