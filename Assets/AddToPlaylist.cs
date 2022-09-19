using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AddToPlaylist : MonoBehaviour
{
    public GameObject Content;
    string Playlistname = null;
    static bool PlaylistSelected = false;
    public void addToPlaylist()
    {

        PlaylistSelected = false;
        GameObject[] Button = new GameObject[Content.transform.childCount];

        for (int counter = 0; counter < Content.transform.childCount; counter++)
        {
            Button[counter] = Content.transform.GetChild(counter).gameObject;
            if (Button[counter].transform.GetChild(1).gameObject != null)
            {
                if (Button[counter].transform.GetChild(1).GetComponent<Toggle>().isOn)
                {
                    GameObject btn = Button[counter];
                    StartCoroutine(WaitTillPlaylistChoosen(PlaylistSelected, btn));
                }
            }
        }
    }
    private IEnumerator WaitTillPlaylistChoosen(bool PlaylistSelected, GameObject Btn)
    {
        yield return new WaitUntil(() => getSelected());
        Btn.GetComponent<Playlist>().addtoPlaylist(Playlistname);
        this.GetComponent<ButtonAddPlaylist>().leavePlaylistDeclaration();
        Playlistname = null;
        PlaylistSelected = false;
        StopAllCoroutines();
    }
    public void choosePlaylist(string playlistname)
    {
        Playlistname = playlistname;
        PlaylistSelected = true;
        //StopAllCoroutines();
    }

    bool getSelected()
    {
        return PlaylistSelected;
    }
}
