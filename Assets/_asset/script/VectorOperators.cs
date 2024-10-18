using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorOperators : MonoBehaviour
{
    [SerializeField] private Vector3 vector1;
    [SerializeField] private Vector3 vector2;
    [SerializeField] private Vector3 cong;
    [SerializeField] private Vector3 tru;
    [SerializeField] private Vector3 nhan;
    [SerializeField] private Vector3 chia;

    // Start is called before the first frame update
    void OnEnable()
    {
        Debug.Log("PrintOnEnable: script was enabled");
    }
    void Start()
    {
        vector1 = new Vector3(1, 2, 3);
        vector2 = new Vector3(4, 5, 6);
        cong = vector1 + vector2;
        tru = vector1 - vector2;
        nhan = vector1 * 2;
        chia = vector1 / 2;
        Debug.Log("Addition: " + cong);
        Debug.Log("Subtraction: " + tru);
        Debug.Log("Multiplication: " + nhan);
        Debug.Log("Division: " + chia);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}
