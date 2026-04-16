using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Restart : MonoBehaviour
{
  

    private void Start()
    {
        
    }
    public void restartGame()
    {
     
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
