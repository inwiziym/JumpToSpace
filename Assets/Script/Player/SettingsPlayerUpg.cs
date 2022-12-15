using UnityEngine;

public class SettingsPlayerUpg : MonoBehaviour
{
    public GameObject nonresources;
    public GameObject windows;

    //��������� ������� �� 240 ������ (2 �����)
    public void UpgTimerLvl1()
    {
        int DuctTape = PlayerPrefs.GetInt("DuctTapeScope"),
            Plastic = PlayerPrefs.GetInt("PlasticScope"),
            WiresScope = PlayerPrefs.GetInt("WiresScope");


        if (DuctTape >= 30 && Plastic >= 25 && WiresScope >= 15)
        {
            PlayerPrefs.SetInt("DuctTapeScope", DuctTape - 30);
            PlayerPrefs.SetInt("PlasticScope", Plastic - 25);
            PlayerPrefs.SetInt("PlasticScope", WiresScope - 15);
            PlayerPrefs.SetFloat("GameTimer", 240f);
        }
        else
        {
            nonresources.SetActive(true);
        }
    }

    //��������� ������� �� 600 ������ (10 �����)
    public void UpgTimerLvl2()
    {
        int DuctTape = PlayerPrefs.GetInt("DuctTapeScope"),
            Plastic = PlayerPrefs.GetInt("PlasticScope"),
            WiresScope = PlayerPrefs.GetInt("WiresScope");


        if (DuctTape >= 60 && Plastic >= 50 && WiresScope >= 30)
        {
            PlayerPrefs.SetInt("DuctTapeScope", DuctTape - 60);
            PlayerPrefs.SetInt("PlasticScope", Plastic - 50);
            PlayerPrefs.SetInt("PlasticScope", WiresScope - 30);
            PlayerPrefs.SetFloat("GameTimer", 600f);
        }
        else
        {
            nonresources.SetActive(true);
        }
    }

    //��������� ������� �� 1800 ������ (30 �����)
    public void UpgTimerLvl3()
    {
        int DuctTape = PlayerPrefs.GetInt("DuctTapeScope"),
            Plastic = PlayerPrefs.GetInt("PlasticScope"),
            WiresScope = PlayerPrefs.GetInt("WiresScope");


        if (DuctTape >= 120 && Plastic >= 100 && WiresScope >= 60)
        {
            PlayerPrefs.SetInt("DuctTapeScope", DuctTape - 120);
            PlayerPrefs.SetInt("PlasticScope", Plastic - 100);
            PlayerPrefs.SetInt("PlasticScope", WiresScope - 60);
            PlayerPrefs.SetFloat("GameTimer", 1800f);
        }
        else
        {
            nonresources.SetActive(true);
        }
    }

    //������ ������
    //public void repairWindow()
    //{
    //    int DuctTape = PlayerPrefs.GetInt("DuctTapeScope");

    //    if (DuctTape >= 30)
    //    {
    //        PlayerPrefs.SetInt("DuctTapeScope", DuctTape - 30);
    //    }
    //    else
    //    {
    //        nonresources.SetActive(true);
    //    }
    //}
}
