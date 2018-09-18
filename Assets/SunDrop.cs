using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunDrop : MonoBehaviour {

    // Use this for initialization
    public float dropSpeed;


    void Update()
    {
        transform.Translate(0, -dropSpeed, 0);

        Destroy(gameObject, 3f);
        Debug.Log("destroyed");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        
        GameManager.instance.score++;
        Destroy(collision.gameObject);

        Destroy(gameObject);
     
        
    }
}
