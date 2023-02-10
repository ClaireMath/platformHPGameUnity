using UnityEngine;
//using UnityEngine.SceneManagement;


public class DisappearObject : MonoBehaviour
{

    public GameObject objectToDestroy;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("on est dans la colision");
            Destroy(objectToDestroy);
           // GameLifeScript.health -= 1;
            //  SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
    }
}