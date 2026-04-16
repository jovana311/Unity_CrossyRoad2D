using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class PreveziPile : MonoBehaviour
{
    public Generisanje logic;
    public Kamera pomeranjeKamere;
    public Debla parent;

    float tajmer = 0;
    float ubrzanje = 4;

    void Start()
    {
       
        parent = gameObject.transform.root.GetComponent<Debla>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Generisanje>();
        pomeranjeKamere = GameObject.FindGameObjectWithTag("Logic").GetComponentInChildren<Transform>().Find("Main Camera").GetComponent<Kamera>();
      


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {

            logic.addScore(1);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
    
        if (other.gameObject.name.StartsWith("Pile"))
        {
            other.transform.Translate(parent.getV() * Time.deltaTime, Space.Self);

           

            if (tajmer < ubrzanje)
            {
                tajmer += Time.deltaTime;
                pomeranjeKamere.Pomeri(1, parent.getV());

            }
            else
            {
                ubrzanje = 4;
                tajmer = 0;
                other.GetComponent<PileKretanje>().gameOver();
            }

        }
    }
}
