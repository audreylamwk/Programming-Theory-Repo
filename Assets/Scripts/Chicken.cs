using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Animals
{
    // Start is called before the first frame update
    public override void Jump()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * 5, ForceMode.Impulse);

    }


    void Start()
    {
        InvokeRepeating("Jump", 1.0f, 2.0f);
    }
    void Update()
    {
        SetName();
    }
}
