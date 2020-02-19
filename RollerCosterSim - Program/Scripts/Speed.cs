using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speed : MonoBehaviour {

    public float speed;
    public Text speedText;
    public Text g_forceText;
    public float[] g_forceSpeed = new float[1];
    public float gravity = Physics.gravity.magnitude;

    private int number = 1;
    private int counter = 0;
    private bool draw = true;

    void FixedUpdate()
    {

        speed = GetComponent<Rigidbody2D>().velocity.magnitude;

        if (counter == number)
        {
            g_forceSpeed[counter] = speed;

            if (Time.time != 0)
            {
                g_forceText.text = "Current gForce: " + ((g_forceSpeed[counter] - g_forceSpeed[counter - 1]) / (Time.deltaTime * gravity)).ToString("0.0") + " g";
                counter = 0;
            }
            else
            {
                g_forceText.text = "Current gForce: 0 g";
                counter = 0;
            }

        }
        
        speedText.text = "Current Speed: " + (speed * 3.6).ToString("0.00") + "km/h";

        g_forceSpeed[counter] = speed;
        counter++;
    }

    void Update()
    {
        LineRenderer lineRenderer = gameObject.GetComponent<LineRenderer>();
        lineRenderer.enabled = true;

        if (draw == true)
        {
            lineRenderer.SetVertexCount(2);
            lineRenderer.SetPosition(0, transform.position);
            if (speed < 2)
                lineRenderer.SetPosition(1, speed / 2 * transform.forward + transform.position);
            else if (speed > 7)
                lineRenderer.SetPosition(1, speed / 5 * transform.forward + transform.position);
            else
                lineRenderer.SetPosition(1, speed / 3 * transform.forward + transform.position);
        }
        else
            lineRenderer.enabled = false;
    }

    public void Checked(bool value)
    {
        if (value == true) { 
            draw = true;
           
        }
        else
            draw = false;
           
    }


}
