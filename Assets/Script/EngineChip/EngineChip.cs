using UnityEngine;

public class EngineChip : MonoBehaviour
{
    public GameObject nonresources;
    public GameObject RepEngine;
    public LoadScopeObj updscope;

    public Animator FireEngine;

    public void RepEngineChip()
    {
        int DuctTape = PlayerPrefs.GetInt("DuctTapeScope"),
            Iron = PlayerPrefs.GetInt("IronScope"),
            Copper = PlayerPrefs.GetInt("CopperScope"),
            Wires = PlayerPrefs.GetInt("WiresScope"),
            Motherboard = PlayerPrefs.GetInt("MotherboardScope");

        if (DuctTape >= 50 && Iron >= 20 && Copper >=  20 && Wires >= 15 && Motherboard >= 5)
        {
            PlayerPrefs.SetInt("DuctTapeScope", DuctTape - 50);
            PlayerPrefs.SetInt("IronScope", Iron - 20);
            PlayerPrefs.SetInt("CopperScope", Copper - 20);
            PlayerPrefs.SetInt("WiresScope", Wires - 15);
            PlayerPrefs.SetInt("MotherboardScope", Motherboard - 5);

            FireEngine.enabled= true;

            PlayerPrefs.SetInt("RepEngineChip", 0);
            RepEngine.SetActive(false);
            updscope.Start();

        }
        else
        {
            nonresources.SetActive(true);
        }
    }
}
