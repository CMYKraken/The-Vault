using UnityEngine;

public class BridgeBehaviour : MonoBehaviour
{
    [Header("Bridge dimensions")]
    public uint width = 2;
    public uint length = 10;
    
    [Header("Object references")]
    public BridgeBlockBehaviour[] bridgeItems; // bridge items is used as reference to each item that will make up the bridge
    
    private Vector3[,] _positions;
    
    void Start()
    {
        var transformToBridge = transform.position;
        
        bridgeItems = FindObjectsByType<BridgeBlockBehaviour>();
        
        _positions = new Vector3[width,length];
        
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < length; j++)
            {
                _positions[i,j] = new Vector3(i,0,j);
                bridgeItems[i*length+j].targetPosition = transformToBridge + _positions[i,j];
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
