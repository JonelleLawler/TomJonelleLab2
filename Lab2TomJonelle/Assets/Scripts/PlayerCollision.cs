using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    Vector2 temp;

    public float x = 0.5f;
    public float y = 0.5f;
    public float z = 0.5f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit detected");
        Destroy(other.gameObject);
        transform.localScale += new Vector3(x, y, z);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
