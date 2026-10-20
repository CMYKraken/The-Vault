using UnityEngine;

public class BridgeBehaviour : MonoBehaviour
{
    [Header("Bridge dimensions")]
    public uint width = 2;
    public uint length = 10;
    
    [Header("Object references")]
    private BridgePlatform[,] _bridgePlatforms;
    
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
                newPlatform.transform.position = new Vector3(i,0,j);
                
                _bridgePlatforms[i, j] = newPlatform;
            }
        }
    }
    
}
