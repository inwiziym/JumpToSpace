using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectControl : MonoBehaviour
{

    public void ControlAsseliration()
    {
        PlayerPrefs.SetInt("SelectControl", 0);
    }


    public void Control2button()
    {
        PlayerPrefs.SetInt("SelectControl", 1);
    }


    public void ControlButtonRight()
    {
        PlayerPrefs.SetInt("SelectControl", 2);
    }


    public void ControlHalfScreeen()
    {
        PlayerPrefs.SetInt("SelectControl", 3);
    }





}
