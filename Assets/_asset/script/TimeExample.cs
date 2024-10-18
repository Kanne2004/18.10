using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeExample : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for ( ; ; )
        {
            Debug.Log("Time since start: " + Time.time);
            Debug.Log("Time between frames: " + Time.deltaTime);
            if (Time.time > 5)
            {
                Debug.LogError("Thoi gian lon hon 5!");
            }
            if (Time.time > 10)
            {
                Debug.LogError("Thoi gian lon hon 10!");
            }
            break;
        }
    }
}
