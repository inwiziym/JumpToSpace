using System.Drawing;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public GameObject godeadscreen;
    public GameObject goui;

    public GameObject PlayerGO;
    public GameObject AstGO;
    public GameObject BlackHoleGO;

    public float MoveSpeedAstX;
    public float MoveSpeedAstY;
    public float MoveSpeedAstZ;

    public GameObject LeftWarring;
    public GameObject RightWarring;

    public GameObject AsteroidGO;

    public AudioSource Music;

    public void Update()
    {
        transform.position = transform.position + new Vector3(MoveSpeedAstX, MoveSpeedAstY, MoveSpeedAstZ);
    }

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

            Music.mute = true;

            PlayerGO.SetActive(false);
            AstGO.SetActive(false);
            BlackHoleGO.SetActive(false);
            Collider2D.gameObject.SetActive(false);
        }
    }


    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.name == "DeadZone")
        {
            float RandX = Random.Range(-6f, 6f);
            float RandY = transform.position.y + 17f;

            if(RandX > (0))
            {
                MoveSpeedAstX = Random.Range(-0.009f, -0.007f);
                Vector3 newRotation = new Vector3(0, 0, -18);
                transform.eulerAngles = newRotation;
                RightWarring.SetActive(true);
                LeftWarring.SetActive(false);

            }
            else
            {
                MoveSpeedAstX = Random.Range(0.007f, 0.009f);
                Vector3 newRotation = new Vector3(0, 0, 18);
                transform.eulerAngles = newRotation;

                RightWarring.SetActive(false);
                LeftWarring.SetActive(true);
            }

            transform.position = new Vector3(RandX, RandY, 0);
        }
    }

}
