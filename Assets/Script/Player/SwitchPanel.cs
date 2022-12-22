using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchPanel : MonoBehaviour
{
    public GameObject goplayer;
    public GameObject gomehanic;

    public void SwitchPanelPlayer()
    {
        if(PlayerPrefs.GetFloat("GameTimer") >= 960f)
        {
            gomehanic.SetActive(true);
        }

        else if (PlayerPrefs.GetFloat("GameTimer") >= 120f)
        {
            goplayer.SetActive(true);
        }

    }
}
