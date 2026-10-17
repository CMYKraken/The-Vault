using UnityEngine;

public class BridgeBehaviour : MonoBehaviour
{
    [Header("Bridge dimensions")]
    public uint width = 2;
    public uint length = 10;
    
    [Header("Object references")]
    public GameObject[] bridgeItems; // bridge items is used as reference to each item that will make up the bridge
    
    private Vector3[,] _positions;
    
    void Start()
    {
        _positions = new Vector3[width,length];
        
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < length; j++)
            {
                _positions[i,j] = new Vector3(i,0,j);
            }
        }

        foreach (var VARIABLE in _positions)
        {
            print(VARIABLE);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
