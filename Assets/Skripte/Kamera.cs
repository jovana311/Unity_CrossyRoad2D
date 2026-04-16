using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using static UnityEngine.GraphicsBuffer;

public class Kamera : MonoBehaviour
{
    public GameObject pile;
    public Vector3 offset;
    public float smoothTime = 0.25f;
    public Vector3 velocity = new Vector3(0,0,0);

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) || 
            Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D) ||
            Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S) ||
            Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            Vector3 target = new Vector3(pile.transform.position.x, pile.transform.position.y, 0);
            Pomeri(0, offset);
        }

    }

    public void Pomeri(int  flag, Vector3 pomeraj)
    {
        Vector3 target = new Vector3(pile.transform.position.x+offset.x, pile.transform.position.y+offset.y, 0);
        transform.position = Vector3.Lerp(transform.position, target, 0.25F);

        
    }

}


