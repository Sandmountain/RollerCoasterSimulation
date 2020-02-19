using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderGravValue : MonoBehaviour
{
    public Text textComponent;
    public Slider slider;
    public RigidbodySlideValues rsv;

    void Start()
    {
        slider.value = rsv.gravityScale;
    }

    // Update is called once per frame
    void Update()
    {
        textComponent.text = (slider.value * rsv.gravityScale).ToString("0.0");
        rsv.rb.gravityScale = Mathf.Round(slider.value);
    }
}
