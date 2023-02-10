using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameControlScript.health -= 1;
            // GameLifeScript.health -= 1;
            //if (GameControlScript.gameOver)
            //{
            //    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //}

        }
    }
}
