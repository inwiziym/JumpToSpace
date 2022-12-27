using UnityEngine;

public class AllGame : MonoBehaviour
{
    public void Start()
    {
        if (PlayerPrefs.GetFloat("GameTimer") < 120f)
        {
            RestartGame();
        }
    }



    public void RestartGame()
    {
        PlayerPrefs.SetInt("ScorePlayer", 0);
        PlayerPrefs.SetInt("DuctTapeScope", 0); //изолента
        PlayerPrefs.SetInt("WiresScope", 0); //ѕровода
        PlayerPrefs.SetInt("PlasticScope", 0); //ѕластик

        PlayerPrefs.SetInt("OreIronScope", 0); //руди железа
        PlayerPrefs.SetInt("OreCopperScope", 0); //реды меди

        PlayerPrefs.SetInt("IronScope", 0); //железо
        PlayerPrefs.SetInt("CopperScope", 0); //медь
        PlayerPrefs.SetInt("WiresScope", 0); //провода
        PlayerPrefs.SetInt("MotherboardScope", 0); //мат платы

        PlayerPrefs.SetInt("repwindows0", 1);
        PlayerPrefs.SetInt("repwindows1", 1);
        PlayerPrefs.SetInt("repwindows2", 1);
        PlayerPrefs.SetInt("repwindows3", 1);

        PlayerPrefs.SetFloat("GameTimer", 120f);
        PlayerPrefs.SetFloat("GameTimerUpd", 240f);

        PlayerPrefs.SetInt("TextUpgTimerLvl1", 10);
        PlayerPrefs.SetInt("TextUpgTimerLvl2", 10);
        PlayerPrefs.SetInt("TextUpgTimerLvl3", 5);

        PlayerPrefs.SetInt("repcaptainbridge", 0);
        PlayerPrefs.SetInt("RepEngineChip", 1);
        PlayerPrefs.SetInt("RepVentilation", 1);

    }
}
