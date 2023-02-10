using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameLifeScript : MonoBehaviour
{

    public GameObject oneLife, gameOver;
    public static int health;
    // Start is called before the first frame update
    void Start()
    {

        health = 1;
        oneLife.gameObject.SetActive (true);
        gameOver.gameObject.SetActive (false);
        
    }

    // Update is called once per frame
    void Update()
    {

        if (health < 1)
        {
            health = 0;
            gameOver.gameObject.SetActive(true);
            Time.timeScale = 0;
            
        }
        
    }


    // public void ResetTheGame(){
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    // }


}
