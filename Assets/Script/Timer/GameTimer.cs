using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{    
    [SerializeField] private Text timerText;
    public GameObject godeadscreen;
    public GameObject goui;

    Image timerBar;
    public float gameTime;
    float timeLeft;
    private float _timeLeft = 0f;

    void Start()
    {
        _timeLeft = gameTime;
        timerBar = GetComponent<Image>();
        timeLeft = gameTime;
    }

    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / gameTime;
        }
        else
        {
            PlayerPrefs.SetInt("DuctTapeScope", PlayerPrefs.GetInt("DuctTapeScope", 0) + allobjscale.DuctTape);
            PlayerPrefs.SetInt("WiresScope", PlayerPrefs.GetInt("WiresScope", 0) + allobjscale.Wires);
            PlayerPrefs.SetInt("PlasticScope", PlayerPrefs.GetInt("PlasticScope", 0) + allobjscale.Plastic);
            godeadscreen.SetActive(true);
            goui.SetActive(false);
            Time.timeScale = 0;
        }
        if(_timeLeft > 0)
        {
            _timeLeft -= Time.deltaTime;
            UpdateTimeText();
        }
    }
    private void UpdateTimeText()
    {
        if (_timeLeft < 0)
            _timeLeft = 0;

        float minutes = Mathf.FloorToInt(_timeLeft / 60);
        float seconds = Mathf.FloorToInt(_timeLeft % 60);
        timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}