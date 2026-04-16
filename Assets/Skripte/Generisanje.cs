using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Generisanje : MonoBehaviour
{
    public GameObject Trava;
    public GameObject Put;
    public GameObject Voda;
   
    int randIzbor;
    int randDuzina;
    public float udaljenost = 12;
    public int playerScore = 0;
    public Text ScoreText;


    Vector3 pozicija = new Vector3(0,-3.5F,2);
    int prethodna=0;

    
    public void addScore(int score)
    {
        playerScore = playerScore + score;
        ScoreText.text = playerScore.ToString();
    }
   
    void Start()
    {
        CreateTrava();
        CreatePut();
        CreateTrava();

    }
    private void CreateVoda()
    {
        randDuzina = Random.Range(1, 3);
        for (int i = 0; i < randDuzina; i++)
        {
            pozicija = new Vector3(pozicija.x + 1.5F, udaljenost, 2);
            udaljenost += 2.3F;

            int voda = Random.Range(1, 3);
            GameObject istVoda;
         
            istVoda = Instantiate(Voda, pozicija, Voda.transform.rotation) as GameObject;
            istVoda.transform.position = pozicija;
            istVoda.transform.localScale += new Vector3(5, 0, 0);
        }
    }
    private void CreateTrava()
    {
        randDuzina = Random.Range(1, 3);

        for (int i = 0; i < randDuzina; i++)
        {
            pozicija = new Vector3(pozicija.x + 1.5F, udaljenost, 2);
            udaljenost += 2.3F;
            GameObject istTrava = Instantiate(Trava) as GameObject;
            istTrava.transform.position = pozicija;
            istTrava.transform.localScale += new Vector3(5, 0, 0);
        }
    }
    private void CreatePut()
    {
        randDuzina = Random.Range(1, 4);
        int izabrano = -1;
        for (int i = 0; i < randDuzina; i++)
        {
            pozicija = new Vector3(pozicija.x +1.5F, udaljenost, 2);
            udaljenost += 2.3F;

           
            GameObject istPut;
      
            istPut = Instantiate(Put, pozicija, Put.transform.rotation) as GameObject;
            int novoIzabrano = UnityEngine.Random.Range(0, 3);
            while (novoIzabrano == izabrano)
            {
                novoIzabrano = UnityEngine.Random.Range(0, 3);
            }
            
            istPut.GetComponent<Autoput>().izabrano = novoIzabrano;
            izabrano = novoIzabrano;


            istPut.transform.localScale += new Vector3(5, 0, 0);

        }

    }

    void Update()
    {
        transform.position = transform.position + (Vector3.up * 0.1F * Time.deltaTime);
        if (Input.GetButtonDown("up"))
        {

            randIzbor = Random.Range(1, 4);
            if(prethodna==0)
            {
                prethodna = randIzbor;
            }
            else
            {
                while (prethodna == randIzbor) {
                    randIzbor = Random.Range(1, 4);
                }
                prethodna= randIzbor;
            }
            

            if (randIzbor == 1)
            {
                CreateTrava();
            }
            else if (randIzbor == 2)
            {
                CreateVoda();
            }
            else
            {
                CreatePut();
            }

        }

    }

    //
}
