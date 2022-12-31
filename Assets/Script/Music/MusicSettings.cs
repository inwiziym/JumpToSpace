using UnityEngine.UI;
using UnityEngine;

public class MusicSettings : MonoBehaviour
{
    public AudioSource[] audioSource;
    public string Prefs;


    public void Start()
    {
        for (int i = 0; i < audioSource.Length; i++)
        {
            audioSource[i].mute = PlayerPrefs.GetInt(Prefs) == 0;
        }

    }


}
