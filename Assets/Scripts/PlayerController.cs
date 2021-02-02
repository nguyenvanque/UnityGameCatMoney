using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float maxSpeed;
    public float jumpHeight;

    bool facingRight;
    bool grounded;
    bool canbemove;
    //khai bao cac bien de nem kunai

   


    Rigidbody2D myBody;
    public Animator myAnim;
    // Use this for initialization
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();

        facingRight = true;
        canbemove = true;

    }

    // Update is called once per frame
    void FixedUpdate()
   
    {
     
        if (canbemove==true)
        {
            float move = Input.GetAxis("Horizontal");

            myAnim.SetFloat("Speed", Mathf.Abs(move));

            myBody.velocity = new Vector2(move * maxSpeed, myBody.velocity.y);

            if (move > 0 && !facingRight)
            {
                _flip();
            }
            else if (move < 0 && facingRight)
            {
                _flip();
            }

            if (Input.GetKey(KeyCode.Space))
            {
                if (grounded)
                {
                    grounded = false;
                    myBody.velocity = new Vector2(myBody.velocity.x, jumpHeight);
                }
                myAnim.SetBool("Jump", true);
            }
            else
            {
                myAnim.SetBool("Jump", false);
            }

        }

    }

    void _flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
        if (collision.gameObject.tag == "Obstacle")
        {
            canbemove = false;
     
            myAnim.SetBool("Die", true);
            myAnim.Play("DieAnimation");
            //gameObject.SetActive(false);
            //Time.timeScale = 0;

            Gamecontroller.instance.GameOver();

        }
        if (collision.gameObject.tag == "water")
        {
            canbemove = false;
            myAnim.SetBool("Die", true);
         
            myAnim.Play("DieAnimation");
            // gameObject.SetActive(false);
            // Time.timeScale = 0;
            Gamecontroller.instance.GameOver();


        }
        if (collision.gameObject.tag == "Shootable")
        {
            canbemove = false;
            myAnim.SetBool("Die", true);
      
            myAnim.Play("DieAnimation");
            //gameObject.SetActive(false);
            //Time.timeScale = 0;

            Gamecontroller.instance.GameOver();

        }
    }
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            canbemove = false;
            myAnim.SetBool("Die", true);
       
            myAnim.Play("DieAnimation");
            // gameObject.SetActive(false);
            //Time.timeScale = 0;
            Gamecontroller.instance.GameOver();


        }
        if (collision.gameObject.tag == "water")
        {
            canbemove = false;
            myAnim.SetBool("Die", true);
      
            myAnim.Play("DieAnimation");
            // gameObject.SetActive(false);
            //Time.timeScale = 0;
            Gamecontroller.instance.GameOver();


        }
        if (collision.gameObject.tag == "Shootable")
        {
            canbemove = false;

            myAnim.SetBool("Die", true);
            myAnim.Play("DieAnimation");
            //gameObject.SetActive(false);
            //Time.timeScale = 0;

            Gamecontroller.instance.GameOver();

        }
    }
    public void setcanbemove(bool b)
    {
        canbemove = b;
    }
    //chuc nang nem phi tiêu
}
