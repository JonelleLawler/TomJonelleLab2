using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallPlanet : MonoBehaviour
{
    private float speed;
    private float moveHorizontal;
    private float moveVertical;

    int size = 1;


    private Rigidbody2D rb2d;
    private int count;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        speed = Random.Range(1, 3);
        moveHorizontal = Random.Range(-2, 2);
        moveVertical = Random.Range(-2, 2);

    }

    void FixedUpdate()
    {
        Vector2 movement = new Vector2(moveHorizontal, moveVertical) ;
        rb2d.AddForce(movement * speed);

        if(transform.position.x >= 10.922)
        {
         ;
        }

        if(transform.position.x <= -9.078)
        {
          
        }

        if(transform.position.y >= 8.366)
        {
            
        }

       if(transform.position.y <= -6.634)
        {
           
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        //moveHorizontal = moveHorizontal * -1;
        //moveVerticle = moveVerticle * -1;


        //Debug.Log("HIT HIT HIT!");

        /*
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
        }
        */

    }
}
