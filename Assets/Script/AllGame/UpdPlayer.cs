using UnityEngine;

public class UpdPlayer : MonoBehaviour
{
    public GameTimer TimerGame;
    void Start()
    {
        TimerGame.gameTime = PlayerPrefs.GetFloat("GameTimer", 120f);

    }
}
