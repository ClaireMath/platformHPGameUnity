using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartScript : MonoBehaviour
{
    public GameObject objectToDestroy;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameControlScript.health += 1;
            Destroy(objectToDestroy);
        }
    }
}