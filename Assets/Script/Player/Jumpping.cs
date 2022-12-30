using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jumpping : MonoBehaviour
{

    public Rigidbody2D rb2D;
    public float verticalSpeed;

    public GameObject FireLeft;
    public GameObject FireRight;
    public Animator AnimFireLeft;
    public Animator AnimFireRight;
    bool Upping = false;

    public Slider NitroS;
    bool Waiting;

    public void DownUp()
    {
        if (!Waiting)
        {
            FireLeft.SetActive(true);
            FireRight.SetActive(true);
            AnimFireLeft.enabled = true;
            AnimFireRight.enabled = true;
            Upping = true;
        }
    }
    public void UpUp()
    {
        FireLeft.SetActive(false);
        FireRight.SetActive(false);
        AnimFireLeft.enabled = false;
        AnimFireRight.enabled = false;

        Upping = false;
    }

    public void Update()
    {
        if(Upping && !Waiting)
        {
            if(NitroS.value > NitroS.minValue )
            {
                NitroS.value -= Time.deltaTime;
            }

            else
            {
                Waiting = true;
                UpUp();
            }
        }
        else
        {
            if (NitroS.value < NitroS.maxValue)
            {
                NitroS.value += Time.deltaTime;

            }
        }

        if(NitroS.value > NitroS.maxValue / 2)
        {
            Waiting = false;
        }

        if (Upping && rb2D.velocity.y < 7 && !Waiting)
        {
            rb2D.AddForce(transform.up * verticalSpeed, ForceMode2D.Impulse);

        }
    }
}
