using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTitle : MonoBehaviour
{
    public Text TrackTop, TrackPlayer;

    public void setTrack()
    {
        TrackTop.GetComponent<Text>().text = this.GetComponentInChildren<Text>().text;
        TrackPlayer.GetComponent<Text>().text = this.GetComponentInChildren<Text>().text;
    }
}
