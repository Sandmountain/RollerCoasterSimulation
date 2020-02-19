using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class reset : MonoBehaviour {


    public double maxXPosition = 50.5;
    private Vector3 initialPosition;
    private Quaternion initialRotation;

    // Use this for initialization
    void Start()
    {
        initialPosition = transform.position;
        initialRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.up * Time.deltaTime);

        if (gameObject.transform.position.x >= maxXPosition)
        {
            transform.rotation = initialRotation;
            transform.position = initialPosition;
        }

    }
    public void resetButton()
    {
    
        transform.rotation = initialRotation;
        transform.position = initialPosition;
    }

}

