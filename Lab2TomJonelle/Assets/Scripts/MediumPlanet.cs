using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediumPlanet : MonoBehaviour
{
    private float speed;
    private float moveHorizontal;
    private float moveVerticle;


    private Rigidbody2D rb2d;
    private int count;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        speed = Random.Range(0.5f, 1f);
        moveHorizontal = Random.Range(-2, 2);
        moveVerticle = Random.Range(-2, 2);

    }

    void FixedUpdate()
    {
       
        Vector2 movement = new Vector2(moveHorizontal, moveVerticle);
        rb2d.AddForce(movement * speed);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        /*
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count++;
            setCountText();
        }
        */
    }
}

