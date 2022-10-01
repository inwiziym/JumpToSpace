using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text ScoreText;
    [SerializeField] Text HighScoreText;
    public static int score;
    public GameObject Camera;

    void Start()
    {
        score = 0;
        HighScoreText.text = "������� ������: " + PlayerPrefs.GetInt("score").ToString();
    }
    void Update()
    {        
        if(Camera.transform.position.y < 0)
        {
            score = 0;
        }
        else
        {
            score = (int) Camera.transform.position.y;
        } 

        ScoreText.text = "����: " + score.ToString();
        if (PlayerPrefs.GetInt("score") <= score)
        {
            PlayerPrefs.SetInt("score", score);
            HighScoreText.text = "����� ������: " + PlayerPrefs.GetInt("score").ToString();
        }

    }
}