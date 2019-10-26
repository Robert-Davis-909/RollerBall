using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallSpeed : MonoBehaviour
{
    public static float speed = 500;
    public Slider Ballslider;
    public Text BallsliderText;

    void Update()
    {
        BallsliderText.text = Ballslider.value.ToString();
        speed = Ballslider.value;
        PlayerPrefs.SetFloat("BallSpeed", speed);
    }
}
