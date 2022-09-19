using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random : MonoBehaviour
{
    bool shuffleon = false;
    public GameObject shuffleOn, shuffleOff;

    public void shuffle()
    {
        shuffleon = !shuffleon;
        shuffleOn.SetActive(shuffleon);
        shuffleOff.SetActive(!shuffleon);
    }
}
