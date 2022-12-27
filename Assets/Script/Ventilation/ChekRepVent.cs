using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChekRepVent : MonoBehaviour
{
    public GameObject RepVent;

    public void ChekRepVentilation()
    {
        if (PlayerPrefs.GetInt("RepVentilation") == 1)
        {
            RepVent.SetActive(true);
        }
        else
        {
            RepVent.SetActive(false);
        }
    }
}
