using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfLevel : MonoBehaviour

{

  //  public GameObject objectToDestroy;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("on est dans la colision Hagrid");
           // Application.LoadLevel(0);
            // GameLifeScript.health -= 1;
            SceneManager.LoadScene(0);

        }
    }
}
