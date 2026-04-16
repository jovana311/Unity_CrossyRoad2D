
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class Put: MonoBehaviour
{
   
    public List<Prepreka> listaPrepreka;
    public GameObject kamera;
    [SerializeField]
    public float broj;
  
    public float deadZone;
    
    public Put(List<Prepreka> listaPrepreka, GameObject kamera, float broj, float deadZone)
    {
        this.listaPrepreka = listaPrepreka;
        this.kamera = kamera;
        this.broj = broj;
        this.deadZone = deadZone;
    }

    public void Start1()
    {

        kamera = GameObject.FindGameObjectWithTag("MainCamera");
        
    }

    public abstract void Unisti();
    public abstract GameObject Istanciraj();

    


}
