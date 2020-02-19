using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderMassValue : MonoBehaviour
{
    public Text textComponent;
    public Slider slider;
    public RigidbodySlideValues rsv;

    void Start()
    {
        slider.value = rsv.mass;
    }

    // Update is called once per frame
    void Update()
    {
        textComponent.text = Mathf.Round(slider.value * rsv.mass).ToString();
        rsv.rb.mass = Mathf.Round(slider.value * rsv.mass);
    }
}
