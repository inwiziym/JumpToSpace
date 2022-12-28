using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public void TheStartGame()
    {
        PlayerPrefs.SetInt("TheStartGame", 0);
    }
}
