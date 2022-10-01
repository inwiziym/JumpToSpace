using UnityEngine;

public class Pause : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1;
    }
    public void StopPause()
    {
        Time.timeScale = 0;
    }
    public void PlayGame()
    {
        Time.timeScale = 1;
    }
}
