using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGameObject : MonoBehaviour
{
    [SerializeField] private GameObject myObject;
    // Start is called before the first frame update
    void Start()
    {
        myObject = new GameObject("MyGameObject");
        myObject.AddComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
