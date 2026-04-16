using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using System;
using Unity.VisualScripting;


public class Drvece : PreprekeNaPutu
{
    public Drvece(float brzina, Vector3 pomeraj, float deadZone) : base(brzina, pomeraj, deadZone)
    {
    }
    
    void Start()
    {
        brzina = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
