using UnityEngine;


public class Ventilation : MonoBehaviour
{
    public GameObject nonresources;
    public GameObject RepVent;
    public LoadScopeObj updscope;

    public Animator Blade;


    public AudioSource audioSource;

    public void RepVentilation()
    {
        int Iron = PlayerPrefs.GetInt("IronScope"),
            Wires = PlayerPrefs.GetInt("WiresScope");

        if (Iron >= 10 && Wires >= 5)
        {
            PlayerPrefs.SetInt("IronScope", Iron - 10);
            PlayerPrefs.SetInt("WiresScope", Wires - 5);


            Blade.enabled = true;
            audioSource.mute = false;
            PlayerPrefs.SetInt("RepVentilation", 0);
            RepVent.SetActive(false);
            updscope.Start();

        }
        else
        {
            nonresources.SetActive(true);
        }
    }

}
