using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChekCreateJumpping : MonoBehaviour
{
    public GameObject CreateJumpping;

    public void ChekCreateJumppingGo()
    {
        if (PlayerPrefs.GetInt("CreateJumpping") == 1)
        {
            CreateJumpping.SetActive(true);
        }
        else
        {
            CreateJumpping.SetActive(false);
        }
    }

}
