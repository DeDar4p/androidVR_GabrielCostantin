﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatecube : MonoBehaviour
{
    public float spinforce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, spinforce * Time.deltaTime, 0);
    }
 
}
