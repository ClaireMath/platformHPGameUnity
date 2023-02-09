using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    private  Rigidbody2D rb2D;

    private float moveSpeed;
    private float jumpForce;
    private bool isJumping;
    private float moveHorizontal;
    private float moveVertical;
    private bool m_FacingRight;
    private bool isDead;
    private float _elapsedTime;
    private int counter;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();

        moveSpeed = 3f;
        jumpForce = 60f;
        isJumping = false;
        m_FacingRight = true;
        isDead = false;
        _elapsedTime = 0;
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");
        //Debug.Log(moveHorizontal);
        //Debug.Log(moveVertical);
    }

    void FixedUpdate()
    {
        if(moveHorizontal > 0.1f || moveHorizontal < -0.1f)
        {
             rb2D.AddForce(new Vector2(moveHorizontal * moveSpeed, 0f), ForceMode2D.Impulse);
             // If the input is moving the player right and the player is facing left...
             			if (moveHorizontal > 0 && !m_FacingRight)
             			{
             				// ... flip the player.
             				Flip();
             			}
             			// Otherwise if the input is moving the player left and the player is facing right...
             			else if (moveHorizontal < 0 && m_FacingRight)
             			{
             				// ... flip the player.
             				Flip();
             			}
        }
    animator.SetFloat("Speed", Mathf.Abs(moveHorizontal));
        if(!isJumping && moveVertical > 0.1f)
        {
             rb2D.AddForce(new Vector2(0f, moveVertical * jumpForce), ForceMode2D.Impulse);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Platform")
        {
            isJumping = false;
            animator.SetBool("isJumping", false);
        }
        if(collision.gameObject.tag == "Trap")
                {
                    isJumping = false;
                    animator.SetBool("isJumping", false);
                    isDead = true;
                    animator.SetBool("isDead", true);
                    Death();
                }

    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Platform")
        {
            isJumping = true;
            animator.SetBool("isJumping", true);
        }
        if(collision.gameObject.tag == "Trap")
                        {
                            Death();
                        }
    }

    void Flip()
    	{
    		// Switch the way the player is labelled as facing.
    		m_FacingRight = !m_FacingRight;

    		// Multiply the player's x local scale by -1.
    		Vector2 theScale = transform.localScale;
    		theScale.x *= -1;
    		transform.localScale = theScale;
    	}

        void Death()
        {
            isDead = true;
            animator.SetBool("isDead", true);
            Application.LoadLevel(1);


        }
}
