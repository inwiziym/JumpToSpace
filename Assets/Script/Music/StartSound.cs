using UnityEngine;
using UnityEngine.UI;
public class StartSound : MonoBehaviour
{
    public string Prefs;
    public AudioSource[] audioSource;
    
    private Toggle Toggletoggle;
    // Start is called before the first frame update
    void Start()
    {
        Toggletoggle = GetComponent<Toggle>();
        Toggletoggle.isOn = PlayerPrefs.GetInt(Prefs) == 0;
    }

    public void soundChanged()
    {
        PlayerPrefs.SetInt(Prefs, Toggletoggle.isOn ? 0 : 1);
        for(int i = 0; i < audioSource.Length; i++)
        {
            audioSource[i].mute = !Toggletoggle.isOn;
        }
    }
}
