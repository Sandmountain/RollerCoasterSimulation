using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alpha : MonoBehaviour {
    public Image image;
	// Use this for initialization
	void Start () {
        image = GetComponent<Image>();
        Color c = image.color;
        c.a = 0.7f;
        image.color = c;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
