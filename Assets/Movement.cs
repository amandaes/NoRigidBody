using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float moveSpeed = 0.05f;
    public bool facingRight = true;
    
	// Use this for initialization
	void Start () {

       

	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(moveSpeed*Time.deltaTime, 0, 0);
            facingRight = true;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-moveSpeed*Time.deltaTime, 0, 0);
            facingRight = false;
        }

        

        Vector3 theScale = transform.localScale;
        if (facingRight)
            theScale.x = Mathf.Abs(theScale.x);
        else
            theScale.x = -Mathf.Abs(theScale.x);

        transform.localScale = theScale;
	}

   
}
