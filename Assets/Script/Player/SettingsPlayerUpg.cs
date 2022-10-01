using UnityEngine;

public class SettingsPlayerUpg : MonoBehaviour
{
    public void UpgTimer()
    {
        int DuctTape = PlayerPrefs.GetInt("DuctTapeScope"),
            Plastic = PlayerPrefs.GetInt("PlasticScope");

        if(DuctTape >= 5 && Plastic >= 3)
        {
            PlayerPrefs.SetInt("DuctTapeScope", DuctTape - 5);
            PlayerPrefs.SetInt("PlasticScope", Plastic - 3);
            PlayerPrefs.SetFloat("GameTimer", 240f);
        }
        else
        {
            //setactive game object
        }
    }
}
