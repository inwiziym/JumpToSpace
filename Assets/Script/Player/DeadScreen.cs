using UnityEngine;

public class DeadScreen : MonoBehaviour
{
    public GameObject godeadscreen;
    public GameObject goui;

    public GameObject Asteroid;
    public GameObject Player;

    public AudioSource Music;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "player")
        {
            PlayerPrefs.SetInt("DuctTapeScope", PlayerPrefs.GetInt("DuctTapeScope", 0) + allobjscale.DuctTape);
            PlayerPrefs.SetInt("WiresScope", PlayerPrefs.GetInt("WiresScope", 0) + allobjscale.Wires);
            PlayerPrefs.SetInt("PlasticScope", PlayerPrefs.GetInt("PlasticScope", 0) + allobjscale.Plastic);
            PlayerPrefs.SetInt("OreIronScope", PlayerPrefs.GetInt("OreIronScope", 0) + allobjscale.OreIron);
            PlayerPrefs.SetInt("OreCopperScope", PlayerPrefs.GetInt("OreCopperScope", 0) + allobjscale.OreCopper);
            godeadscreen.SetActive(true);
            goui.SetActive(false);
            Asteroid.SetActive(false);
            Player.SetActive(false);
            collision.gameObject.SetActive(false);


            Music.mute = true;
        }
    }

}
