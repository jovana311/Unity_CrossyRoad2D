using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PokreniIgru : MonoBehaviour
{
    public GameObject pile;
    public GameObject tekst;
    public GameObject level;

    void Start()
    {
        pile.SetActive(true);
        tekst.SetActive(true);
        level.SetActive(false);
        Button btnpokreni = GameObject.Find("Pokreni").GetComponent<Button>();
        btnpokreni.onClick.AddListener(OnPokreniClick);

     
    }

    private void OnPokreniClick()
    {
        level.SetActive(true);
        SceneManager.LoadScene("Game");
    }

    void Update()
    {
        
    }
   
}

        

