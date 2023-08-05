using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horse : Animals
{
    public override void Jump()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
        rb.AddForce(Vector3.forward * 3, ForceMode.Impulse);

    }


    void Start()
    {
        Jump();
    }
    void Update()
    {
        SetName();
    }
}
