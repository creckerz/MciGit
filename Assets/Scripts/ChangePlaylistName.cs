using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangePlaylistName : MonoBehaviour
{
    public Text Playlist;
    public GameObject addtoPlaylist, SetPlaylistTag;


    public void changeName()
    {
        if (!addtoPlaylist.GetComponent<ButtonAddPlaylist>().getState())
        {
            Playlist.text = this.GetComponentInChildren<Text>().text;
        }
        else
        {
            Playlist.text = this.GetComponentInChildren<Text>().text;
            SetPlaylistTag.GetComponent<AddToPlaylist>().choosePlaylist(this.GetComponentInChildren<Text>().text.ToString());
        }
        
    }
}
