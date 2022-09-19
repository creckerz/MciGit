using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPlay : MonoBehaviour
{
    public GameObject play, stop;
    public void setPlay()
    {
        play.SetActive(false);
        stop.SetActive(true);
    }
    public void changeMode()
    {
        if (play.activeSelf)
        {
            play.SetActive(false);
            stop.SetActive(true);
        }
        else
        {
            play.SetActive(true);
            stop.SetActive(false);
        }
    }

}
