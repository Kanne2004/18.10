using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class test : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake");
    }
    void OnDisable()
    {
        Debug.Log("PrintOnDisable: script was disabled");
    }

    void OnEnable()
    {
        Debug.Log("PrintOnEnable: script was enabled");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // generate a message when the game shuts down
    void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}
