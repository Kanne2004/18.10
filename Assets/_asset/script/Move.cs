using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    int x = 0, y = 0, z = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(x = x - 1, y, 0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position = new Vector3(x, y = y - 1, 0);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position = new Vector3(x, y = y + 1, 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(x = x + 1, y, 0);
        }

    }
}
