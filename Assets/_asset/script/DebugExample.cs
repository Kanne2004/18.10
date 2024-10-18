using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("log message!");
        Debug.LogWarning("log warning message!");
        Debug.LogError("log error message!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
