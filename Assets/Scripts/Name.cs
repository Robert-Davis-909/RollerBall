using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    public static string PlayerName;
    public InputField inputPlayerName;
    public Text showPlayerName;
    public Text rounds;
    public Text ballSpeed;
    public Text cubeSpeed;


    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        showPlayerName.text = PlayerName;
        rounds.text = "Rounds:" + PlayerPrefs.GetInt("rounds");
        ballSpeed.text = "Ball Speed: " + PlayerPrefs.GetFloat("BallSpeed");
        cubeSpeed.text = "Cube Speed: " + PlayerPrefs.GetFloat("SliderValue");
    }

    public void UpdateName()
    {
        PlayerName = inputPlayerName.text;
        showPlayerName.text = PlayerName;
    }

    public void ShowName()
    {
        showPlayerName.text = PlayerName;
    }
}
