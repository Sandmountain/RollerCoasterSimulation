using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderSpeedValue : MonoBehaviour
{
    public Text textComponent;
    public Slider slider;
    public SurfaceEffector2D se2d;

    private void Start()
    {
        se2d = se2d.GetComponent<SurfaceEffector2D>();
        slider.value = se2d.speed;
    }

    // Update is called once per frame
    void Update()
    {
        textComponent.text = Mathf.Round(slider.value*se2d.speed).ToString();
        se2d.speed = (slider.value);
    }
}
