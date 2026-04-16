using System.Collections;

using UnityEngine;
using UnityEngine.SceneManagement;

public class PileKretanje : MonoBehaviour
{
    public GameObject pile;
    public Rigidbody2D r;
    public float brzina=1;
    public GameObject kamera;
    public GameObject gameOverScreen;

 
    void Start()
    {
        r = GetComponent<Rigidbody2D>();
        pile.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
        kamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    void Update()
    {
       
        transform.position = transform.position + (Vector3.down * 0.1F * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            pile.transform.Translate(new Vector2(-1.5F, 0.5F) * brzina , Space.World);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            pile.transform.Translate(new Vector2(2, -0.5F) * brzina , Space.World);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            pile.transform.Translate(new Vector2(1, 1.7F) * brzina , Space.World);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            pile.transform.Translate(new Vector2(-1.5F, -1.5F) * brzina , Space.World);
        }
        
        

        if ((transform.position.y - 0.5F) < (kamera.transform.position.y - 5))
        {
            gameOver();
        }
    

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
      
        if (!collision.gameObject.name.StartsWith("Drvo"))
        {
            
            gameOver();
        }
            
        
    }
   
    public void gameOver()
    {
      
        pile.SetActive(false);
        gameOverScreen.SetActive(true);
    }
    

}
