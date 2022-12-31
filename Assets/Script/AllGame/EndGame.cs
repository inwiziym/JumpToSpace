using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public string[] Prefs;
    public int[] PravilnoePref;
    private bool AllGood;
    public GameObject EHERAZ;
    public GameObject ENDGAME;

    public void RepChip()
    {
        AllGood = true;
        for(int i = 0; i < Prefs.Length; i++)
        {
            if (PlayerPrefs.GetInt(Prefs[i]) != PravilnoePref[i])
            {
                EHERAZ.SetActive(true);
                AllGood = false;
            }
        }
        if(AllGood)
        {
            ENDGAME.SetActive(true);
        }
    }




}
