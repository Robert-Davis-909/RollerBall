using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 800.0f;
    public Text ScoreText;
    public Text WinText;
    private static int count = 0;
    public static int highscore = 0;
    public int rounds = 0;
    public AudioClip audioClip;
    public AudioSource audioSource;

    public GameObject pickUp;
    public GameObject pickUp1;
    public GameObject pickUp2;
    public GameObject pickUp3;
    public GameObject pickUp4;
    public GameObject pickUp5;
    public GameObject pickUp6;
    public GameObject pickUp7;
    public GameObject pickUp8;
    public GameObject pickUp9;
    public GameObject pickUp10;
    public GameObject pickUp11;
    public GameObject pickUp12;
    public GameObject pickUp13;
    public GameObject pickUp14;
    public GameObject pickUp15;

     void Awake()
    {
        count = 0;
        audioSource.clip = audioClip;
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        speed = PlayerPrefs.GetFloat("BallSpeed");

        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
        rounds = PlayerPrefs.GetInt("rounds");
        if (rounds == 1)
        {
            if (count == 16)
            {
                WinText.gameObject.SetActive(true);
            }
        }
        if (rounds == 2)
        {
            if (count == 32)
            {
                WinText.gameObject.SetActive(true);
            }
                if(count == 16)
            {
                pickUp.SetActive(true);
                pickUp1.SetActive(true);
                pickUp2.SetActive(true);
                pickUp3.SetActive(true);
                pickUp4.SetActive(true);
                pickUp5.SetActive(true);
                pickUp6.SetActive(true);
                pickUp7.SetActive(true);
                pickUp8.SetActive(true);
                pickUp9.SetActive(true);
                pickUp10.SetActive(true);
                pickUp11.SetActive(true);
                pickUp12.SetActive(true);
                pickUp13.SetActive(true);
                pickUp14.SetActive(true);
                pickUp15.SetActive(true);
            }

        }
        if (rounds == 3)
        {
            if (count == 64)
            {
                WinText.gameObject.SetActive(true);
            }
            if (count == 16)
            {
                pickUp.SetActive(true);
                pickUp1.SetActive(true);
                pickUp2.SetActive(true);
                pickUp3.SetActive(true);
                pickUp4.SetActive(true);
                pickUp5.SetActive(true);
                pickUp6.SetActive(true);
                pickUp7.SetActive(true);
                pickUp8.SetActive(true);
                pickUp9.SetActive(true);
                pickUp10.SetActive(true);
                pickUp11.SetActive(true);
                pickUp12.SetActive(true);
                pickUp13.SetActive(true);
                pickUp14.SetActive(true);
                pickUp15.SetActive(true);
            }
            if (count == 32)
            {
                pickUp.SetActive(true);
                pickUp1.SetActive(true);
                pickUp2.SetActive(true);
                pickUp3.SetActive(true);
                pickUp4.SetActive(true);
                pickUp5.SetActive(true);
                pickUp6.SetActive(true);
                pickUp7.SetActive(true);
                pickUp8.SetActive(true);
                pickUp9.SetActive(true);
                pickUp10.SetActive(true);
                pickUp11.SetActive(true);
                pickUp12.SetActive(true);
                pickUp13.SetActive(true);
                pickUp14.SetActive(true);
                pickUp15.SetActive(true);
            }
        }
        PlayerPrefs.SetInt("rounds", rounds);
        PlayerPrefs.SetInt("Score", count);
        if (count > highscore)
        {
            highscore = count;
        }
        ScoreText.text = "Score: " + count;
        PlayerPrefs.SetInt("HighScore", highscore);
    }
        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "PickUp")
            {
                other.gameObject.SetActive(false);
                count += 1;
            audioSource.Play();
            }

        }
}
