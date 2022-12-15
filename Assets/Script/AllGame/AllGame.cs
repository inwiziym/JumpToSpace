using UnityEngine;

public class AllGame : MonoBehaviour
{
    public void RestartGame()
    {
        PlayerPrefs.SetInt("ScorePlayer", 0);
        PlayerPrefs.SetInt("DuctTapeScope", 0);
        PlayerPrefs.SetInt("WiresScope", 0);
        PlayerPrefs.SetInt("PlasticScope", 0);
        PlayerPrefs.SetInt("OreironScope", 0);
        PlayerPrefs.SetInt("OrecopperScope", 0);
        PlayerPrefs.SetFloat("GameTimer", 120f);

        PlayerPrefs.SetInt("repwindows0", 1);
        PlayerPrefs.SetInt("repwindows1", 1);
        PlayerPrefs.SetInt("repwindows2", 1);
        PlayerPrefs.SetInt("repwindows3", 1);
    }
}
