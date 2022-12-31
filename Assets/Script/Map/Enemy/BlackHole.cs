using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    public GameObject godeadscreen;
    public GameObject goui;

    public GameObject PlayerGO;
    public GameObject AstGO;
    public GameObject BlackHoleGO;

    public AudioSource Music;

    public void OnTriggerEnter2D(Collider2D Collider2D)
    {
        if (Collider2D.tag == "PlayerDie")
        {
            PlayerPrefs.SetInt("DuctTapeScope", PlayerPrefs.GetInt("DuctTapeScope", 0) + allobjscale.DuctTape);
            PlayerPrefs.SetInt("WiresScope", PlayerPrefs.GetInt("WiresScope", 0) + allobjscale.Wires);
            PlayerPrefs.SetInt("PlasticScope", PlayerPrefs.GetInt("PlasticScope", 0) + allobjscale.Plastic);
            PlayerPrefs.SetInt("OreIronScope", PlayerPrefs.GetInt("OreIronScope", 0) + allobjscale.OreIron);
            PlayerPrefs.SetInt("OreCopperScope", PlayerPrefs.GetInt("OreCopperScope", 0) + allobjscale.OreCopper);
            godeadscreen.SetActive(true);
            goui.SetActive(false);

            PlayerGO.SetActive(false);
            AstGO.SetActive(false);
            BlackHoleGO.SetActive(false);

            Music.mute = true;
            Collider2D.gameObject.SetActive(false);
            Time.timeScale = 0;
        }
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.name == "DeadZone")
        {
            float RandX = Random.Range(-2.7f, 2.7f);
            float RandY = transform.position.y + 100f;

            transform.position = new Vector3(RandX, RandY, 0);
        }
    }
}
