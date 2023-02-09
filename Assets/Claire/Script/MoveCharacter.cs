using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    public bool isJumping;

    public Rigidbody2D rb;
    private Vector3 velocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update() { 
    Vector3 movement = new Vector3(0, 0, 0);
    // float horizontalMovement = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.Q))
        {
            movement -= new Vector3(1, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            movement += new Vector3(1, 0, 0);
        }
      
        if (Input.GetKey(KeyCode.Z))
        {
            movement += new Vector3(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            movement -= new Vector3(0, 1, 0);
        }
        transform.position += movement * Time.deltaTime;
    }
    //void fixedupdate()
    //{
    //    float horizontalmovement = input.getaxis("horizontal") * movespeed * time.deltatime;
        
    //    if ( input.getbuttondown("jump"))
    //    {
    //        isjumping = true;
    //    }

    //    movecharacter(horizontalmovement);
    //}

    //void movecharacter(float _horizontalmovement)
    //{
    //    vector3 targetvelocity = new vector2(_horizontalmovement, rb.velocity.y);
    //    rb.velocity = vector3.smoothdamp(rb.velocity, targetvelocity, ref velocity, .05f);

    //    if(isjumping == true)
    //    {
    //        rb.addforce(new vector2(0f, jumpforce));
    //        isjumping= false;
    //    }
    //}
}
