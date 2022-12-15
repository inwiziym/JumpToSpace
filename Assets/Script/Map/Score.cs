using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text ScoreText;
    [SerializeField] Text HighScoreText;
    public static int ScorePlayer;
    public GameObject Camera;

    void Start()
    {
        ScorePlayer = 0;
        HighScoreText.text = "������� ������: " + PlayerPrefs.GetInt("ScorePlayer").ToString();
    }
    void Update()
    {        
        if(Camera.transform.position.y < 0)
        {
            ScorePlayer = 0;
        }
        else
        {
            ScorePlayer = (int) Camera.transform.position.y;
        } 

        ScoreText.text = "����: " + ScorePlayer.ToString();
        if (PlayerPrefs.GetInt("ScorePlayer") <= ScorePlayer)
        {
            PlayerPrefs.SetInt("ScorePlayer", ScorePlayer);
            HighScoreText.text = "����� ������: " + PlayerPrefs.GetInt("ScorePlayer").ToString();
        }

    }
}