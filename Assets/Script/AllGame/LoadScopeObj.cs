using System.Numerics;
using UnityEngine;
using UnityEngine.UI;
public class LoadScopeObj : MonoBehaviour
{
    public Text DuctTape;
    public Text Plastic;
    public Text OreIron;
    public Text OreCopper;
    public Text Iron;
    public Text Copper;
    public Text Wires;
    public Text Motherboard;

    public GameObject[] repwindows;
    public GameObject CaptainBridge;
    public GameObject TextCaptainBridge;

    public Text TextUpgTimer;

    public Text TextUpgTimerLvl1;
    public Text TextUpgTimerLvl2;
    public Text TextUpgTimerLvl3;

    public Animator Blade;

    public void Start()
    {
        for( int i = 0; i < repwindows.Length; i++ )
        {
            bool active;
            if (PlayerPrefs.GetInt("repwindows" + i, 1) == 1)
            {
                active = true;
            }
            else
            {
                active = false;
            }
            repwindows[i].SetActive(active);

        }
        
        if (PlayerPrefs.GetInt("repcaptainbridge", 0) == 1)
        {
            CaptainBridge.SetActive(false);
            TextCaptainBridge.SetActive(true);
        }
        else
        {
            CaptainBridge.SetActive(true);
            TextCaptainBridge.SetActive(false);
        }

        if (PlayerPrefs.GetInt("RepVentilation", 0) == 0)
        {
            Blade.enabled = true;
        }

        DuctTape.text = PlayerPrefs.GetInt("DuctTapeScope", 0).ToString();
        Plastic.text = PlayerPrefs.GetInt("PlasticScope", 0).ToString();
        OreIron.text = PlayerPrefs.GetInt("OreIronScope", 0).ToString();
        OreCopper.text = PlayerPrefs.GetInt("OreCopperScope", 0).ToString();
        Iron.text = PlayerPrefs.GetInt("IronScope", 0).ToString();
        Copper.text = PlayerPrefs.GetInt("CopperScope", 0).ToString();
        Wires.text = PlayerPrefs.GetInt("WiresScope", 0).ToString();
        Motherboard.text = PlayerPrefs.GetInt("MotherboardScope", 0).ToString();

        TextUpgTimer.text = "���������� ����� ������������ ������ �� " + PlayerPrefs.GetFloat("GameTimerUpd", 240f).ToString() + "�";

        TextUpgTimerLvl1.text = PlayerPrefs.GetInt("TextUpgTimerLvl1", 10).ToString();
        TextUpgTimerLvl2.text = PlayerPrefs.GetInt("TextUpgTimerLvl2", 10).ToString();
        TextUpgTimerLvl3.text = PlayerPrefs.GetInt("TextUpgTimerLvl3", 5).ToString();
    }
}
