using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text ScoreText;
    [SerializeField] Text HighScoreText;
    public static int ScorePlayer;
    public GameObject Camera;

    public GameObject[] Jumpping;

    public GameObject SliderN;

    public GameObject[] Control;

    void Start()
    {
        ScorePlayer = 0;
        HighScoreText.text = "Текущий рекорд: " + PlayerPrefs.GetInt("ScorePlayer").ToString();

        int ActivControl = PlayerPrefs.GetInt("SelectControl", 1);
        Control[ActivControl].SetActive(true);

        if (PlayerPrefs.GetInt("Jumpping", 0) == 1)
        {
            Jumpping[ActivControl].SetActive(true);
            SliderN.SetActive(true);
        }
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

        ScoreText.text = "Счет: " + ScorePlayer.ToString();
        if (PlayerPrefs.GetInt("ScorePlayer") <= ScorePlayer)
        {
            PlayerPrefs.SetInt("ScorePlayer", ScorePlayer);
            HighScoreText.text = "Новый рекорд: " + PlayerPrefs.GetInt("ScorePlayer").ToString();
        }
    }
}