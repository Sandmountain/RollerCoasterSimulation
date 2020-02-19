using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodySlideValues : MonoBehaviour {
    public float mass;
    public float gravityScale;
    public float friction;
    public float drag;
    public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
   
        mass = rb.mass;
        gravityScale = rb.gravityScale;
        friction = rb.angularDrag;
        drag = rb.drag;
       

    }
	
	// Update is called once per frame
	void Update () {
        /*
        rb.mass = mass;
        gravityScale = rb.gravityScale;
        friction = rb.angularDrag;
        */
    }
}
