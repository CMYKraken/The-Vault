using System.Collections.Generic;
using UnityEngine;

public class BridgePlatform : MonoBehaviour
{
    [SerializeField] private List<BridgePlatformSegmentBehaviour> segments;
    private readonly Quaternion[] _rotations =  new Quaternion[4];
    private void Awake()
    {
        _rotations[0] = transform.rotation;
        _rotations[1] = Quaternion.Euler(transform.rotation.eulerAngles + Quaternion.AngleAxis(90, Vector3.up).eulerAngles);
        _rotations[2] = Quaternion.Euler(transform.rotation.eulerAngles + Quaternion.AngleAxis(180, Vector3.up).eulerAngles);
        _rotations[3] = Quaternion.Euler(transform.rotation.eulerAngles + Quaternion.AngleAxis(270, Vector3.up).eulerAngles);
    }

    public void AddSegment(BridgePlatformSegmentBehaviour segment)
    {
        segments.Add(segment);
        segment.transform.rotation = _rotations[segments.IndexOf(segment)];
    }

    public void AddSegments(BridgePlatformSegmentBehaviour[] addedSegments)
    {
        foreach (var segment in addedSegments) AddSegment(segment);
    }
}
