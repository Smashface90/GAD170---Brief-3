﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltControls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis ("Horizontal") > -.2)
        {
            transform.Rotate(0, 0, -1);
        }

        if (Input.GetAxis("Horizontal") < .2)
        {
            transform.Rotate(0, 0, 1);
        }

        if (Input.GetAxis("Vertical") > -.2)
        {
            transform.Rotate(-1, 0, 0);
        }
    }
}
