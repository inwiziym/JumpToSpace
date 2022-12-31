using UnityEngine;

public class Pause : MonoBehaviour
{
    public AudioSource Music;
    private void Start()
    {
        Time.timeScale = 1;
    }
    public void StopPause()
    {
        Time.timeScale = 0;
        Music.mute = true;
    }
    public void PlayGame()
    {
        Time.timeScale = 1;
        Music.mute = false;
    }
}
