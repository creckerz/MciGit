using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnterEditMode : MonoBehaviour
{
    public GameObject Content, deleter, playlist, OpenPlayerBtn, PlayBtn;
    public Animator delBtn, playlstBtn;
    int counter = 1;
    bool changemode;

    public void Start()
    {
        changemode = false;
    }
    public void enterEditMain()
    {
        GameObject[] Button = new GameObject[Content.transform.childCount];
        changemode = !changemode;
        if (changemode)
        {
            deleter.SetActive(true);
            delBtn.Play("startDel");
            playlist.SetActive(true);
            playlstBtn.Play("playlistadd");
            OpenPlayerBtn.SetActive(false);
            PlayBtn.SetActive(false);

        }
        else
        {
            deleter.SetActive(false);
            delBtn.Play("leaveDel");
            playlist.SetActive(false);
            playlstBtn.Play("playlistleave");
            OpenPlayerBtn.SetActive(true);
            PlayBtn.SetActive(true);

        }
        for (counter = 0; counter < Content.transform.childCount; counter++)
        {
            Button[counter] = Content.transform.GetChild(counter).gameObject;
            Content.transform.GetChild(counter).GetComponentInChildren<Button>().interactable = !changemode;
            if (Button[counter].transform.GetChild(1).gameObject != null && Button[counter].name != "ButtonRef")
            {
                Button[counter].transform.GetChild(1).gameObject.SetActive(changemode);
            }
        }
    }

    public void enterEdit()
    {
        GameObject[] Button = new GameObject[Content.transform.childCount];
        changemode = !changemode;
        if (changemode)
        {
            deleter.SetActive(true);
            delBtn.Play("startDel");

        }
        else
        {
            deleter.SetActive(false);
            delBtn.Play("leaveDel");

        }
            for(counter = 0; counter < Content.transform.childCount; counter++)
            {
                Button[counter] = Content.transform.GetChild(counter).gameObject;
                Content.transform.GetChild(counter).GetComponentInChildren<Button>().interactable = !changemode;
            if (Button[counter].transform.GetChild(1).gameObject != null && Button[counter].name != "ButtonRef")
                {
                    Button[counter].transform.GetChild(1).gameObject.SetActive(changemode);
                }
            }
    }
}
