using System.Collections.Generic;
using UnityEngine;

public class BridgeBlockBehaviour : MonoBehaviour
{
    public float distance = 1; 
    public List<BridgePlatformSegmentBehaviour> segments;
    public List<Vector3> segmentDirections;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        segments = new List<BridgePlatformSegmentBehaviour>(GetComponentsInChildren<BridgePlatformSegmentBehaviour>());
        for (int i =  0; i < segments.Count; i++)
        {
            segmentDirections.Add(segments[i].transform.localPosition);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < segments.Count; i++)
        {
            segments[i].transform.localPosition = segmentDirections[i]*distance;
        }
    }
    
    public BridgePlatformSegmentBehaviour[] takeSegments(int numSegments)
    {
        List<BridgePlatformSegmentBehaviour> output = new List<BridgePlatformSegmentBehaviour>();
        for (int i = 0; i < numSegments; i++)
        {
            output.Add(segments[0]);
            segments.RemoveAt(0);
        }
        return output.ToArray();
    } 
}
