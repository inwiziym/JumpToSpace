using UnityEngine;
using UnityEngine.UI;
public class SettingsPlayerUpg : MonoBehaviour
{
    public GameObject nonresources;
    public LoadScopeObj updscope;
    public GameObject gomehanic;
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

            if(PlayerPrefs.GetInt("TextUpgTimerLvl1") == 10)
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
}
