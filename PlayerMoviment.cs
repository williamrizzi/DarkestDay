using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    public bool blockMove;

    //Moviment
    public float speed;
    public float speedMod;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    //Animation
    public Animator anim;

    void Start()
    {
        blockMove = false;
        rb = GetComponent<Rigidbody2D>();
        speedMod = 1.15f;
        anim = GetComponentInChildren<Animator>();
    }
    
    void FixedUpdate()
    {
        if(blockMove == false)
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            moveVelocity = new Vector2(x, y);
            moveVelocity *= (speed * speedMod) * Time.deltaTime;
            transform.Translate(moveVelocity);

            if (x != 0 || y != 0)
            {

                anim.SetBool("stopped", false);
                if (x < 0)
                {
                    GetComponentInChildren<SpriteRenderer>().flipX = true;
                }
                else if (x > 0)
                {
                    GetComponentInChildren<SpriteRenderer>().flipX = false;
                }

            }
            else
            {
                anim.SetBool("stopped", true);
            }

        }        


    }
    
}
