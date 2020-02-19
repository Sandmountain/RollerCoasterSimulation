using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderFrictionValue : MonoBehaviour
{
    public Text textComponent;
    public Slider slider;
    public RigidbodySlideValues rsv;

    void Start()
    {
        slider.value = rsv.drag;
    }

    // Update is called once per frame
    void Update()
    {
        textComponent.text = (slider.value * rsv.drag).ToString("0.0");
        rsv.rb.drag = (slider.value * rsv.drag);
    }
}
