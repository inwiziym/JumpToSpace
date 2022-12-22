using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheats : MonoBehaviour
{
    public LoadScopeObj updscope;
    public void CHITbl()
    {
        PlayerPrefs.SetInt("DuctTapeScope", 999);
        PlayerPrefs.SetInt("WiresScope", 999);
        PlayerPrefs.SetInt("PlasticScope", 999);

        PlayerPrefs.SetInt("OreIronScope", 999);
        PlayerPrefs.SetInt("OreCopperScope", 999);

        PlayerPrefs.SetInt("IronScope", 999);
        PlayerPrefs.SetInt("CopperScope", 999);
        PlayerPrefs.SetInt("WiresScope", 999);
        PlayerPrefs.SetInt("MotherboardScope", 999);
        updscope.Start();
    }
}
