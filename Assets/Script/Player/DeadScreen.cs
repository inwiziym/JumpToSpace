using UnityEngine;

public class DeadScreen : MonoBehaviour
{
    public GameObject godeadscreen;
    public GameObject goui;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "player")
        {
            PlayerPrefs.SetInt("DuctTapeScope", PlayerPrefs.GetInt("DuctTapeScope", 0) + allobjscale.DuctTape);
            PlayerPrefs.SetInt("WiresScope", PlayerPrefs.GetInt("WiresScope", 0) + allobjscale.Wires);
            PlayerPrefs.SetInt("PlasticScope", PlayerPrefs.GetInt("PlasticScope", 0) + allobjscale.Plastic);
            PlayerPrefs.SetInt("OreironScope", PlayerPrefs.GetInt("OreironScope", 0) + allobjscale.OreIron);
            PlayerPrefs.SetInt("OrecopperScope", PlayerPrefs.GetInt("OrecopperScope", 0) + allobjscale.OreCopper);
            godeadscreen.SetActive(true);
            goui.SetActive(false);
            collision.gameObject.SetActive(false);
            Time.timeScale = 0;
        }
    }

}
