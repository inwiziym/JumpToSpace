using UnityEngine;

public class CaptainBridge : MonoBehaviour
{
    public GameObject nonresources;
    public GameObject RepWin;
    public LoadScopeObj updscope;
    public GameObject Status;

    public void repcaptainbridge()
    {
        int Wires = PlayerPrefs.GetInt("WiresScope"),
            Iron = PlayerPrefs.GetInt("IronScope"),
            Motherboard = PlayerPrefs.GetInt("MotherboardScope");

        if (Wires >= 6 && Iron >= 4 && Motherboard >= 2)
        {
            PlayerPrefs.SetInt("WiresScope", Wires - 6);
            PlayerPrefs.SetInt("IronScope", Iron - 4);
            PlayerPrefs.SetInt("MotherboardScope", Motherboard - 2);
            PlayerPrefs.SetInt("repcaptainbridge", 1);

            Status.SetActive(true);
            RepWin.SetActive(false);
            updscope.Start();

        }
        else
        {
            nonresources.SetActive(true);
        }
    }
}
