using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class numRounds : MonoBehaviour
{
    public static int rounds = 0;
    public Dropdown roundsDropdown;

     void Update()
    {
        switch(roundsDropdown.value)
        {
            case 1:
                rounds = 1;
                break;
            case 2:
               rounds = 2;
                break;
            case 3:
                rounds = 3;
                break;
        }
        PlayerPrefs.SetInt("rounds", rounds);
    }
}
