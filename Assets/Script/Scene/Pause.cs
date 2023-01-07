using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject StopAsteroid;
    public GameObject Player;
    public GameObject BlackHole;
    bool Freeze;

    private void Start()
    {
        Time.timeScale = 1;

        Freeze = false;
        if (Freeze == false)
        {
            Player.SetActive(true);
            StopAsteroid.SetActive(true);
            BlackHole.SetActive(true);
        }
    }
    public void StopPause()
    {
        Time.timeScale = 0;
        Freeze = true;
        if (Freeze == true)
        {
            Player.SetActive(false);
            StopAsteroid.SetActive(false);
            BlackHole.SetActive(false);
        }
    }
    public void PlayGame()
    {
        Time.timeScale = 1;

        Freeze = false;
        if (Freeze == false)
        {
            Player.SetActive(true);
            StopAsteroid.SetActive(true);
            BlackHole.SetActive(true);
        }
    }
}
