using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour

//Anais
//{ 
//    [SerializeField]
//    private float Speed = 6;

//private Rigidbody2D rb;

//private Vector2 movementDirection;


//// Start is called before the first frame update
//void Start()
//{
//    rb = GetComponent<Rigidbody2D>();
//}

//// Update is called once per frame
//void Update()
//{
//    movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
//}


//void FixedUpdate()
//{

//    rb.velocity = movementDirection * Speed;

//}

//}


// mickael
//{
//    public float playerSpeed;
//    private Rigidbody2D rb;
//    private Vector2 playerDirection;

//    // Start is called before the first frame update
//    void Start()
//    {
//        rb = GetComponent<Rigidbody2D>();
//        Debug.Log(rb);
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        float directionY = Input.GetAxisRaw("Vertical");
//        playerDirection = new Vector2(0, directionY).normalized;
//    }

//    void FixedUpdate()
//    {
//        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
//        Debug.Log(rb.velocity);
//    }
//}


// moi
{
    public float moveSpeed;
    public float jumpForce;
    public bool isJumping;
    private bool isFacingRight = true;
  //  public Rigidbody2D rb;
    private Vector3 velocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(0, 0, 0);

            if (Input.GetKey(KeyCode.Q))
            {
            movement -= new Vector3(5, 0, 0);

                if (isFacingRight)
                {
                isFacingRight = !isFacingRight;
                Vector3 theScale = transform.localScale;
                theScale.x *= -1;
                transform.localScale = theScale;
                }
            }


            if (Input.GetKey(KeyCode.D))
            {
            movement += new Vector3(5, 0, 0);

                if (!isFacingRight)
                {
                isFacingRight = !isFacingRight;
                Vector3 theScale = transform.localScale;
                theScale.x *= -1;
                transform.localScale = theScale;
                }
            }

            if (Input.GetKey(KeyCode.Z))
            {
            movement += new Vector3(0, 5, 0);
            }
        
            if (Input.GetKey(KeyCode.S))
            {
            movement -= new Vector3(0, 5, 0);
            }

            transform.position += movement * Time.deltaTime;
    }



   
}
