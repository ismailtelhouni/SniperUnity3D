using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PourSuite : MonoBehaviour
{

    public Transform target;
    public GameObject autre;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        if (Input.GetKey(KeyCode.Space))
            Destroy(autre);
    }
}
