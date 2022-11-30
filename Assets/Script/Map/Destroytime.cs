using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroytime : MonoBehaviour
{
    public int Time;

    void Start()
    {
        Destroy(gameObject, Time);
    }
}
