using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    public GameObject godeadscreen;
    public GameObject goui;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "player")
        {
            godeadscreen.SetActive(true);
            goui.SetActive(false);
            collision.gameObject.SetActive(false);
            Time.timeScale = 0;
        }
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.name == "DeadZone")
        {
            float RandX = Random.Range(-2.55f, 2.55f);
            float RandY = transform.position.y + 50f;

            transform.position = new Vector3(RandX, RandY, 0);
        }
    }
}
