using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dog : Animals
{


    // Start is called before the first frame update

    private void Start()
    {
        Jump();
    }

    public void Update()
    {
        SetName();
    }




}
