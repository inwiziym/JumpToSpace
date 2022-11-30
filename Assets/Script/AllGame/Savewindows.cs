using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Savewindows : MonoBehaviour
{
    void Start()
    {
        if (PlayerPrefs.GetInt("Windows" + transform.position.ToString()) != 0)
        {
            Destroy(gameObject);
        }
    }
    void Collect()
    {
        PlayerPrefs.SetInt("Windows" + transform.position.ToString(), 1);
        Destroy(gameObject);
    }
}
