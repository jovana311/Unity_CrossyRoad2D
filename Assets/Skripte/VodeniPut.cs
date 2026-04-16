using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VodeniPut : Put
{
    public List<GameObject> gameObjects = new List<GameObject>();

    public float tajmer;
    public float ubrzanje;
    int izabrano;

    public VodeniPut(List<Prepreka> listaPrepreka,  GameObject kamera, float broj,  float deadZone) : base(listaPrepreka,  kamera, broj, deadZone) { }


    public void Start()
    {
        base.Start1();
        izabrano= UnityEngine.Random.Range(0, listaPrepreka.Count);
        GameObject istanca = Istanciraj();
        gameObjects.Add(istanca);

        if (izabrano == 1)
        {
            //levo
            float x = -40;// transform.position.x - 30;
            float y = 11.5F;// (float)((-0.24 * x) + 1.5);

            this.listaPrepreka[izabrano].pocetniPolozaj = new Vector3(x, y, 0);

        }
        else
        {
            //desno
            float x = 30;// transform.position.x + 30;
            float y = -8.2F;// (float)((-0.24 * x) - 1);

            this.listaPrepreka[izabrano].pocetniPolozaj = new Vector3(x, y, 0);
        }
    }

    public override void Unisti()
    {
     
        foreach (GameObject g in gameObjects)
        {
            Destroy(g);
        }
        Destroy(gameObject);
    }

    public override GameObject Istanciraj()
    {

        Vector3 currentPosition = transform.position;
        Vector3 polozaj = listaPrepreka[izabrano].pocetniPolozaj;
        Vector3 vector3 = new Vector3(currentPosition.x + polozaj.x, currentPosition.y + polozaj.y, 2);

        return Instantiate(listaPrepreka[izabrano].prepreka, vector3, listaPrepreka[izabrano].prepreka.transform.rotation);


    }

    void Update()
    {
        deadZone = kamera.transform.position.y - broj;
      
        if (tajmer < ubrzanje)
        {
            tajmer += Time.deltaTime;

        }
        else
        {
            
            tajmer = 0;
            GameObject istanca = Istanciraj();

            //SpriteRenderer spriteRenderer = istanca.GetComponent<SpriteRenderer>();
            //spriteRenderer.sortingOrder = this.GetComponent<SpriteRenderer>().sortingOrder - 1;
            gameObjects.Add(istanca);
        }

        if (transform.position.y < deadZone)
        {
            Unisti();

        }
    }
}
