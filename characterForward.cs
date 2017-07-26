using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterForward : MonoBehaviour {

    //public float speed;
    public Rigidbody2D playerBody;
    public float forwardForce;
    public float upSpeed;
    public float maxSpeed;
    //public float drag;
    public float jumpForce;
    //public float zspeed;
    //public EdgeCollider2D onFloor;
    public bool grounded;

    // Use this for initialization
    void Start() {
        playerBody = GetComponent<Rigidbody2D>();
        //onFloor = GetComponent<EdgeCollider2D>();
        grounded = false;
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        grounded = true;       
    }


    void FixedUpdate() {

        if (gameObject.CompareTag("ground"))
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }

        //going forward
        playerBody.AddForce(transform.right * forwardForce);


        //jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerBody.AddForce(transform.up * jumpForce);
            print("space key");
        }
    }
}



