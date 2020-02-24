﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowPressurePlate : MonoBehaviour
{
    public bool isActive = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(gameObject.tag == "YellowPressurePlate" && other.gameObject.tag == "YellowPlayer" || gameObject.tag == "YellowPressurePlate" && other.gameObject.tag == "YellowObject")
        {
            isActive = true;
        }
        else
        {
            isActive = false;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        isActive = false;
    }
}