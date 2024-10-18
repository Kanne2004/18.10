using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 1, 0);

        transform.rotation = Quaternion.Euler(0, 45, 0);

        transform.localScale = new Vector3(2, 2, 2);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
