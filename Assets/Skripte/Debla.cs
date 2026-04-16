using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debla : PreprekeNaPutu
{
    public Debla(float brzina, Vector3 pomeraj, float deadZone) : base(brzina, pomeraj, deadZone)
    {
    }

    void Start()
    {
    }


    void Update()
    {
        gameObject.transform.Translate(base.v() * Time.deltaTime, Space.World);

    }

    public Vector3 getV()
    {
        return base.v();
    }


}
