using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChekPolPodarok : MonoBehaviour
{
    public GameObject PodarokPol;


    public void ChekPodar()
    {
        if (PlayerPrefs.GetInt("Podarochek") == 1)
        {
            PodarokPol.SetActive(true);
        }
        else
        {
            PodarokPol.SetActive(false);
        }
    }
}
