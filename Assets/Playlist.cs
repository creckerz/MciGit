using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playlist : MonoBehaviour
{
    public string[] playlistTag = new string[50];
    public string PlaylistName;
    private int tag = 0;
    bool alreadyInPlaylist = false;
    private void Start()
    {
        this.playlistTag[this.tag] = "All Songs";
    }

    public void addtoPlaylist(string playlistName)
    {
        for(int i = 0; i < playlistTag.Length; i++){
            if(playlistTag[i] == playlistName)
            {
                alreadyInPlaylist = true;
            }
        }
        if (!alreadyInPlaylist)
        {
            this.tag++;
            playlistTag[this.tag] = playlistName;
            PlaylistName = playlistName;
            alreadyInPlaylist = false;
            playlistName = null;
        }
    } 

    public string getPlaylist()
    {
        return PlaylistName;
    }

    public string[] getArray()
    {
        return this.playlistTag;
    }
}
