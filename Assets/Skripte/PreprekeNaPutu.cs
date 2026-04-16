using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

[System.Serializable]
public abstract class PreprekeNaPutu: MonoBehaviour
{
    public float brzina ;
    public Vector3 pomeraj;
    public float deadZone ;

    public PreprekeNaPutu(float brzina, Vector3 pomeraj, float deadZone)
    {
        this.brzina = brzina;
        this.pomeraj = pomeraj;
        this.deadZone = deadZone;
    }

    public Vector3 v() { 
    
       Vector3 v3 = pomeraj * brzina;
       return v3;
    }



}
