using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateResourse : MonoBehaviour
{
    public GameObject nonresources;
    public LoadScopeObj updscope;

    public void CreateIron()
    {
        int OreIron = PlayerPrefs.GetInt("OreIronScope");

        if (OreIron >= 5)
        {
            PlayerPrefs.SetInt("OreIronScope", OreIron - 5);
            PlayerPrefs.SetInt("IronScope", PlayerPrefs.GetInt("IronScope", 0) + 1);
            updscope.Start();

        }
        else
        {
            nonresources.SetActive(true);
        }
    }

    public void CreateCopper()
    {
        int OreCopper = PlayerPrefs.GetInt("OreCopperScope");

        if (OreCopper >= 5)
        {
            PlayerPrefs.SetInt("OreCopperScope", OreCopper - 5);
            PlayerPrefs.SetInt("CopperScope", PlayerPrefs.GetInt("CopperScope", 0) + 1);
            updscope.Start();

        }
        else
        {
            nonresources.SetActive(true);
        }
    }

    public void CreateWires()
    {
        int DuctTape = PlayerPrefs.GetInt("DuctTapeScope"),
        Copper = PlayerPrefs.GetInt("CopperScope");

        if (DuctTape >= 5 && Copper >= 1)
        {
            PlayerPrefs.SetInt("DuctTapeScope", DuctTape - 5);
            PlayerPrefs.SetInt("CopperScope", Copper - 1);
            
            PlayerPrefs.SetInt("WiresScope", PlayerPrefs.GetInt("WiresScope", 0) + 1);
            updscope.Start();

        }
        else
        {
            nonresources.SetActive(true);
        }
    }

    public void CreateMotherboard()
    {
        int DuctTape = PlayerPrefs.GetInt("DuctTapeScope"),
        Copper = PlayerPrefs.GetInt("CopperScope"),
        Iron = PlayerPrefs.GetInt("IronScope");

        if (DuctTape >= 5 && Copper >= 3 && Iron >= 3)
        {
            PlayerPrefs.SetInt("DuctTapeScope", DuctTape - 5);
            PlayerPrefs.SetInt("CopperScope", Copper - 3);
            PlayerPrefs.SetInt("IronScope", Iron - 3);

            PlayerPrefs.SetInt("MotherboardScope", PlayerPrefs.GetInt("MotherboardScope", 0) + 1);
            updscope.Start();

        }
        else
        {
            nonresources.SetActive(true);
        }
    }
}
