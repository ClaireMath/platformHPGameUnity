using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarryPotterRun : MonoBehaviour
{
    
    [SerializeField]
    private float Speed = 6;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // transform.position += new Vector3(1,0,0) * Time.deltaTime;
        
       //

       Vector3 movement = new Vector3(0, 0, 0);

       if (Input.GetKey(KeyCode.Z))
       {
            movement += new Vector3(1, 0, 0);
       }

        if (Input.GetKey(KeyCode.A))
       {
            movement -= new Vector3(0, 1, 0);
       }
       
        transform.position +=  movement * Speed * Time.deltaTime;

    }
}
