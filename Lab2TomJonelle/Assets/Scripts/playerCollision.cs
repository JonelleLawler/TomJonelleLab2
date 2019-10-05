using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    //Check collider
    private CircleCollider2D circCollider;
    float volume;


    //Increase Ratios
    private float x;
    private float y;
    private float z;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Vector3 geometry = other.bounds.size;
        float otherVolume = geometry.x * geometry.y;
        Debug.Log(otherVolume);

        if(volume > otherVolume)
        {
            //Destroy the Asteroid
            Destroy(other.gameObject);

            //get new value for collider
            circCollider = GetComponent<CircleCollider2D>();
            geometry = circCollider.bounds.size;
            Debug.Log(geometry);
            volume = (geometry.x * geometry.y) + otherVolume;
            Debug.Log(volume);

            //Update Player mass
            x = otherVolume / 3.14f;
            y = otherVolume / 3.14f;

            //
            GameObject.Find("Player").transform.localScale += new Vector3(x, y, z);

            ScoreScript.scoreValue = ScoreScript.scoreValue + 1;

        }
        else if(volume < otherVolume)
        {
            Destroy(transform.parent.gameObject);
            Debug.Log("Player Dies");
            ScoreScript.playerAlive = false; 
        }
        else if(volume == otherVolume)
        {
            Debug.Log("Both same");
        }


    }

    // Start is called before the first frame update
    void Start()
    {
        circCollider = GetComponent<CircleCollider2D>();
        Vector3 geometry = circCollider.bounds.size;
        Debug.Log(geometry);
        volume = geometry.x* geometry.y;
        Debug.Log(volume);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
