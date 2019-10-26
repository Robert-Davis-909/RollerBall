using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class speedSlider : MonoBehaviour
{
    public Slider SpeedSlider;
    public static float sliderValue = 1f;
    public Text sliderText;

    void Start()
    {
        
    }

    void Update()
    {
        sliderValue = SpeedSlider.value;
        sliderText.text = SpeedSlider.value.ToString();
        Rotator.speed = sliderValue;
        PlayerPrefs.SetFloat("SliderValue", sliderValue);
    }

    void ChangeSlider()
    {

    }

}
