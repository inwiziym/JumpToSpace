using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChekRepEnginChip : MonoBehaviour
{
    public GameObject RepEngine;

    public void ChekRepEngine()
    {
        if (PlayerPrefs.GetInt("RepEngineChip") == 1)
        {
            RepEngine.SetActive(true);
        }
        else
        {
            RepEngine.SetActive(false);
        }
    }

}
