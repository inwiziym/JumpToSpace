using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpping : MonoBehaviour
{

    public Rigidbody2D rb2D;
    public float verticalSpeed;

    public GameObject FireLeft;
    public GameObject FireRight;
    public Animator AnimFireLeft;
    public Animator AnimFireRight;
    bool Upping = false;

    public void DownUp()
    {
        FireLeft.SetActive(true);
        FireRight.SetActive(true);
        AnimFireLeft.enabled= true;
        AnimFireRight.enabled = true;
        Upping = true;
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
        if (Upping && rb2D.velocity.y < 7)
        {
            rb2D.AddForce(transform.up * verticalSpeed, ForceMode2D.Impulse);
        }
    }
}
