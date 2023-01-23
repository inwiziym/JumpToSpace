using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Podarok : MonoBehaviour
{
    public GameObject PodarkaNet;
    public LoadScopeObj updscope;
    public void Podarochek()
    {
        int DuctTape = PlayerPrefs.GetInt("DuctTapeScope"),
            Plastic = PlayerPrefs.GetInt("PlasticScope"),
            OreIron = PlayerPrefs.GetInt("OreIronScope"),
            OreCopper = PlayerPrefs.GetInt("OreCopperScope"),
            Iron = PlayerPrefs.GetInt("IronScope"),
            Copper = PlayerPrefs.GetInt("CopperScope"),
            Wires = PlayerPrefs.GetInt("WiresScope"),
            Motherboard = PlayerPrefs.GetInt("MotherboardScope");

        if (DuctTape >= 0 && Plastic >= 0 && OreIron >= 0 && OreCopper >= 0 && Iron >= 0 && Copper >= 0 && Wires >= 0 && Motherboard >= 0)
        {
            PlayerPrefs.SetInt("DuctTapeScope", DuctTape + 30);
            PlayerPrefs.SetInt("PlasticScope", Plastic + 30);
            PlayerPrefs.SetInt("OreIronScope", OreIron + 50);
            PlayerPrefs.SetInt("OreCopperScope", OreCopper + 50);
            PlayerPrefs.SetInt("IronScope", Iron + 10);
            PlayerPrefs.SetInt("CopperScope", Copper + 10);
            PlayerPrefs.SetInt("WiresScope", Wires + 15);
            PlayerPrefs.SetInt("MotherboardScope", Motherboard + 3);
            PodarkaNet.SetActive(false);
            PlayerPrefs.SetInt("Podarochek", 0);
            updscope.Start();

        }
    }
}
