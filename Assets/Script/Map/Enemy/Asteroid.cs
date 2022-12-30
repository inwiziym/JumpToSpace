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

    public float Timer;
    public Transform point;

    public void Update()
    {
        if(Timer <= 0)
        {
            AstGO.transform.position = point.transform.position;
        }
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

            PlayerGO.SetActive(false);
            AstGO.SetActive(false);
            BlackHoleGO.SetActive(false);

            Collider2D.gameObject.SetActive(false);
            Time.timeScale = 0;
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
            }
            else
            {
                MoveSpeedAstX = Random.Range(0.007f, 0.009f);
            }

            transform.position = new Vector3(RandX, RandY, 0);
        }
    }
}
