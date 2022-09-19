using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayAudio : MonoBehaviour
{
    public GameObject MusicPlay;
    private string url;
    public GameObject SaveIndex;

    public void playMusic()
    {
        url = this.GetComponentInChildren<SaveAudio>().getTheUrl();
        MusicPlay.GetComponent<Play>().PlaySong(url, this.GetComponentInChildren<Text>().text);

    }
}
