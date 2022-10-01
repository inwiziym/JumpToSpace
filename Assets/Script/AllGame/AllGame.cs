using UnityEngine;

public class AllGame : MonoBehaviour
{
    public void RestartGame()
    {
        PlayerPrefs.SetInt("score", 0);
        PlayerPrefs.SetInt("DuctTapeScope", 0);
        PlayerPrefs.SetInt("WiresScope", 0);
        PlayerPrefs.SetInt("PlasticScope", 0);
        PlayerPrefs.SetFloat("GameTimer", 120f);
    }
}
