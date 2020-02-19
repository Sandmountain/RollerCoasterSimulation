using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggleScript : MonoBehaviour {

    public Toggle toggle;
    public Speed sfunction;
    public bool state;

	// Use this for initialization
	void Start () {

        Toggle box = toggle.GetComponent<Toggle>();
        box.onValueChanged.AddListener(delegate {
            MyListner(box);
        });      
    }

    public void MyListner(Toggle change)
    {
        state = change.isOn; 
        sfunction.Checked(state);
    }

}
