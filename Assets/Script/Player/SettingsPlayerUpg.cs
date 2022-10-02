using UnityEngine;

public class SettingsPlayerUpg : MonoBehaviour
{
    public GameObject nonresources;
    public GameObject windows;

    //��������� ������� �� 240 ������ (2 �����)
    public void UpgTimerLvl1()
    {
        int DuctTape = PlayerPrefs.GetInt("DuctTapeScope"),
            Plastic = PlayerPrefs.GetInt("PlasticScope");


        if (DuctTape >= 25 && Plastic >= 30)
        {
            PlayerPrefs.SetInt("DuctTapeScope", DuctTape - 25);
            PlayerPrefs.SetInt("PlasticScope", Plastic - 30);
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
            Plastic = PlayerPrefs.GetInt("PlasticScope");

        if (DuctTape >= 40 && Plastic >= 50)
        {
            PlayerPrefs.SetInt("DuctTapeScope", DuctTape - 40);
            PlayerPrefs.SetInt("PlasticScope", Plastic - 50);
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
            Plastic = PlayerPrefs.GetInt("PlasticScope");

        if (DuctTape >= 80 && Plastic >= 100)
        {
            PlayerPrefs.SetInt("DuctTapeScope", DuctTape - 80);
            PlayerPrefs.SetInt("PlasticScope", Plastic - 100);
            PlayerPrefs.SetFloat("GameTimer", 1800f);
        }
        else
        {
            nonresources.SetActive(true);
        }
    }

    //������ ������
    public void repairWindow()
    {
        int DuctTape = PlayerPrefs.GetInt("DuctTapeScope");

        if (DuctTape >= 30)
        {
            PlayerPrefs.SetInt("DuctTapeScope", DuctTape - 30);
        }
        else
        {
            nonresources.SetActive(true);
        }
    }
}
