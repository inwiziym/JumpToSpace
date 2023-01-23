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

    public GameObject TheStartGo;
    public GameObject CanvasGame;

    public GameObject[] repwindows;
    public GameObject CaptainBridge;
    public GameObject TextCaptainBridge;
    public GameObject Status;
    public Text TextUpgTimer;

    public Text TextUpgTimerLvl1;
    public Text TextUpgTimerLvl2;
    public Text TextUpgTimerLvl3;

    public Animator Blade;

    public GameObject FireEngineIm;
    public Animator FireEngine;


    public GameObject ImJumppingLeft;
    public GameObject ImJumppingRight;

    public AudioSource AudioSourceVent;
    public AudioSource AudioSourceEngine;

    public GameObject PodarokActive;


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
            Status.SetActive(true);
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
            AudioSourceVent.mute = false;
        }

        if (PlayerPrefs.GetInt("TheStartGame", 1) == 0)
        {
            TheStartGo.SetActive(false);
            CanvasGame.SetActive(true);
        }


        if (PlayerPrefs.GetInt("RepEngineChip", 1) == 0)
        {
            FireEngineIm.SetActive(true);
            FireEngine.enabled = true;
            AudioSourceEngine.mute = false;
        }

        if (PlayerPrefs.GetInt("Podarochek", 1) == 0)
        {
            PodarokActive.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Jumpping", 0) == 1)
        {
            ImJumppingLeft.SetActive(true);
            ImJumppingRight.SetActive(true);
        }



        DuctTape.text = PlayerPrefs.GetInt("DuctTapeScope", 0).ToString();
        Plastic.text = PlayerPrefs.GetInt("PlasticScope", 0).ToString();
        OreIron.text = PlayerPrefs.GetInt("OreIronScope", 0).ToString();
        OreCopper.text = PlayerPrefs.GetInt("OreCopperScope", 0).ToString();
        Iron.text = PlayerPrefs.GetInt("IronScope", 0).ToString();
        Copper.text = PlayerPrefs.GetInt("CopperScope", 0).ToString();
        Wires.text = PlayerPrefs.GetInt("WiresScope", 0).ToString();
        Motherboard.text = PlayerPrefs.GetInt("MotherboardScope", 0).ToString();

        TextUpgTimer.text = "ћаксильное врем€ кислородного балона на " + PlayerPrefs.GetFloat("GameTimerUpd", 240f).ToString() + "с";

        TextUpgTimerLvl1.text = PlayerPrefs.GetInt("TextUpgTimerLvl1", 10).ToString();
        TextUpgTimerLvl2.text = PlayerPrefs.GetInt("TextUpgTimerLvl2", 10).ToString();
        TextUpgTimerLvl3.text = PlayerPrefs.GetInt("TextUpgTimerLvl3", 5).ToString();

    }
}
