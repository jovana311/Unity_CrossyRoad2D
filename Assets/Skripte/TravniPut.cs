using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using System;
using Unity.VisualScripting;

public class TravniPut : Put
{
    public List<GameObject> gameObjects = new List<GameObject>();
    int izabrano;

    public TravniPut(List<Prepreka> listaPrepreka,  GameObject kamera, float broj, float deadZone) : base(listaPrepreka, kamera, broj, deadZone) { }



    void Start()
    {
        izabrano = UnityEngine.Random.Range(0, listaPrepreka.Count);
        GameObject istanca = Istanciraj();

        //SpriteRenderer spriteRenderer = istanca.GetComponent<SpriteRenderer>();
        //spriteRenderer.sortingOrder = this.GetComponent<SpriteRenderer>().sortingOrder - 1;
        gameObjects.Add(istanca);
        
    }


    void Update()
    {
        base.Start1();
        deadZone = kamera.transform.position.y - broj;

        if (transform.position.y < deadZone)
        {

            Unisti();
        }
    }



    public override GameObject Istanciraj()
    {
        
        Vector3 currentPosition = transform.position;
        Vector3 polozaj = listaPrepreka[0].pocetniPolozaj;
        Vector3 vector3 = new Vector3(currentPosition.x + polozaj.x, currentPosition.y + polozaj.y, 2);

        return Instantiate(listaPrepreka[izabrano].prepreka, vector3, listaPrepreka[izabrano].prepreka.transform.rotation);


    }

    public override void Unisti()
    {
        foreach (GameObject g in gameObjects)
        {
            Destroy(g);
        }
        Destroy(gameObject); 
    }
}
