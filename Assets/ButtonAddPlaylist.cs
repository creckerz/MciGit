using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAddPlaylist : MonoBehaviour
{
    private bool setToPlaylist = false;

    public void setToPlaylists()
    {
        setToPlaylist = true;
    }

    public bool getState()
    {
        return setToPlaylist;
    }

    public void leavePlaylistDeclaration()
    {
        setToPlaylist = false;
    }
}
