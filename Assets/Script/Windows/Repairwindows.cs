using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repairwindows : MonoBehaviour
{
    public GameObject nonresources;
    public GameObject RepWin;
    public LoadScopeObj updscope;

    public void repairwind()
    {
        int WiresScope = PlayerPrefs.GetInt("DuctTapeScope"),
            Plastic = PlayerPrefs.GetInt("PlasticScope");

        if (WiresScope >= 10 && Plastic >= 10)
        {
            PlayerPrefs.SetInt("DuctTapeScope", WiresScope - 10);
            PlayerPrefs.SetInt("PlasticScope", Plastic - 10);
            PlayerPrefs.SetInt("repwindows0", 0);
            RepWin.SetActive(false);
            updscope.Start();

        }
        else
        {
            nonresources.SetActive(true);
        }
    }

    public void repairwind2()
    {
        int WiresScope = PlayerPrefs.GetInt("DuctTapeScope"),
            Plastic = PlayerPrefs.GetInt("PlasticScope");

        if (WiresScope >= 10 && Plastic >= 10)
        {
            PlayerPrefs.SetInt("DuctTapeScope", WiresScope - 10);
            PlayerPrefs.SetInt("PlasticScope", Plastic - 10);
            PlayerPrefs.SetInt("repwindows1", 0);
            RepWin.SetActive(false);
            updscope.Start();
        }
        else
        {
            nonresources.SetActive(true);
        }
    }

    public void repairwind3()
    {
        int WiresScope = PlayerPrefs.GetInt("DuctTapeScope"),
            Plastic = PlayerPrefs.GetInt("PlasticScope");

        if (WiresScope >= 10 && Plastic >= 10)
        {
            PlayerPrefs.SetInt("DuctTapeScope", WiresScope - 10);
            PlayerPrefs.SetInt("PlasticScope", Plastic - 10);
            PlayerPrefs.SetInt("repwindows2", 0);
            RepWin.SetActive(false);
            updscope.Start();
        }
        else
        {
            nonresources.SetActive(true);
        }
    }


    public void repairwind4()
    {
        int WiresScope = PlayerPrefs.GetInt("DuctTapeScope"),
            Plastic = PlayerPrefs.GetInt("PlasticScope");

        if (WiresScope >= 10 && Plastic >= 10)
        {
            PlayerPrefs.SetInt("DuctTapeScope", WiresScope - 10);
            PlayerPrefs.SetInt("PlasticScope", Plastic - 10);
            PlayerPrefs.SetInt("repwindows3", 0);
            RepWin.SetActive(false);
            updscope.Start();
        }
        else
        {
            nonresources.SetActive(true);
        }
    }
}
