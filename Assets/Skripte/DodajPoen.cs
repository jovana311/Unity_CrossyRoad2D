using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DodajPoen : MonoBehaviour
{

    public Generisanje logic;
   
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Generisanje>();
    }

    void Update()
    {
        
    }
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
         logic.addScore(1);
        }
            
    }
}
