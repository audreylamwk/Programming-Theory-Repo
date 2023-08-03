using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals : MonoBehaviour
{

    public Rigidbody rb;
    public float jumpforce = 10;

    // Start is called before the first frame update
    public void Jump()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
    }
}
