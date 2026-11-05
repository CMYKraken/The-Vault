using UnityEngine;
using System.Collections.Generic;

public class BridgeBehaviour : MonoBehaviour
{
    [Header("Bridge dimensions")]
    public float spacing = 1; 
    public uint width = 2;
    public uint length = 10;
    
    [Header("Object references")]
    private BridgePlatform[,] _bridgePlatforms;
    private Stack<BridgeBlockBehaviour> _blocks;
    
    private int segmentsPerPlatform = 4;
    
    void Start()
    {
        _bridgePlatforms = new BridgePlatform[width, length];
        
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < length; j++)
            {
                //Create new bridge platform 
                var newPlatform = new GameObject("BridgePlatform" + i +" , " + j)
                    .AddComponent<BridgePlatform>();
                newPlatform.transform.position = new Vector3(i,0,j) * spacing;
                
                _bridgePlatforms[i, j] = newPlatform;
            }
        }
    }

    private void PopluatePlatforms()
    {
        _blocks = new Stack<BridgeBlockBehaviour>(GameObject.FindObjectsByType<BridgeBlockBehaviour>());

        foreach (var platform in _bridgePlatforms)
        {
            var diff = _blocks.Peek().segments.Count - segmentsPerPlatform;
            if (diff < 0)
            {
                platform.AddSegments(_blocks.Peek().takeSegments(segmentsPerPlatform+diff));
                _blocks.Pop();
                platform.AddSegments(_blocks.Peek().takeSegments(-diff));
            }
            else
            {
                platform.AddSegments(_blocks.Peek().takeSegments(segmentsPerPlatform));
            }
        }
        
    }
    
}
