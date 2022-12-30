using UnityEngine;
using UnityEngine.UI;
public class SettingsPlayerUpg : MonoBehaviour
{
    public GameObject nonresources;
    public LoadScopeObj updscope;
    public GameObject gomehanic;
    public GameObject JumppingGO;
    public GameObject Jumppingbt;
    public GameObject ImJumppingLeft;
    public GameObject ImJumppingRight;
    public void UpgTimerLvl1()
    {
        int DuctTape = PlayerPrefs.GetInt("DuctTapeScope"),
            Plastic = PlayerPrefs.GetInt("PlasticScope"),
            Wires = PlayerPrefs.GetInt("WiresScope");


        if (DuctTape >= PlayerPrefs.GetInt("TextUpgTimerLvl1") && Plastic >= PlayerPrefs.GetInt("TextUpgTimerLvl2") && Wires >= PlayerPrefs.GetInt("TextUpgTimerLvl3"))
        {
            PlayerPrefs.SetInt("DuctTapeScope", DuctTape - PlayerPrefs.GetInt("TextUpgTimerLvl1"));
            PlayerPrefs.SetInt("PlasticScope", Plastic - PlayerPrefs.GetInt("TextUpgTimerLvl2"));
            PlayerPrefs.SetInt("WiresScope", Wires - PlayerPrefs.GetInt("TextUpgTimerLvl3"));

            if (PlayerPrefs.GetInt("TextUpgTimerLvl1") == 10)
            {
                PlayerPrefs.SetInt("TextUpgTimerLvl1", 20);
                PlayerPrefs.SetInt("TextUpgTimerLvl2", 20);
                PlayerPrefs.SetInt("TextUpgTimerLvl3", 10);
                PlayerPrefs.SetFloat("GameTimerUpd", 480f);
                PlayerPrefs.SetFloat("GameTimer", 240f);

            }
            else if (PlayerPrefs.GetInt("TextUpgTimerLvl1") == 20)
            {
                PlayerPrefs.SetInt("TextUpgTimerLvl1", 30);
                PlayerPrefs.SetInt("TextUpgTimerLvl2", 30);
                PlayerPrefs.SetInt("TextUpgTimerLvl3", 20);
                PlayerPrefs.SetFloat("GameTimerUpd", 960f);
                PlayerPrefs.SetFloat("GameTimer", 480f);

            }

            else if (PlayerPrefs.GetInt("TextUpgTimerLvl1") == 30)
            {
                gameObject.SetActive(false);
                gomehanic.SetActive(true);
                PlayerPrefs.SetFloat("GameTimer", 960f);
            }





            updscope.Start();

        }
        else
        {
            nonresources.SetActive(true);
        }
    }

    public void CreateJummping()
    {
        int DuctTape = PlayerPrefs.GetInt("DuctTapeScope"),
            Iron = PlayerPrefs.GetInt("IronScope");

        if (DuctTape >= 50 && Iron >= 20)
        {
            PlayerPrefs.SetInt("DuctTapeScope", DuctTape - 50);
            PlayerPrefs.SetInt("IronScope", Iron - 20);

            ImJumppingLeft.SetActive(true);
            ImJumppingRight.SetActive(true);

            PlayerPrefs.SetInt("CreateJumpping", 0);
            JumppingGO.SetActive(false);
            PlayerPrefs.SetInt("Jumpping", 1);
            updscope.Start();
        }
        else
        {
            nonresources.SetActive(true);
        }
    }
}
