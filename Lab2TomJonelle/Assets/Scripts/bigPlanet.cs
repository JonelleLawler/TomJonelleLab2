using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigPlanet : MonoBehaviour
{
    private float speed;
    private float moveHorizontal;
    private float moveVerticle;

    //initial spawn
    private float xPos;
    private float yPos;


    private Rigidbody2D rb2d;
    private int count;

    void Start()
    {
        xPos = Random.Range(-30, 30);
        yPos = Random.Range(-20, 20);

        transform.position = new Vector3(xPos, yPos, 1);

        rb2d = GetComponent<Rigidbody2D>();
        speed = Random.Range(0.1f, 0.5f);
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
