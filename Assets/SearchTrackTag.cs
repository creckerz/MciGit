using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchTrackTag : MonoBehaviour
{
    public GameObject Content, addPlayer;
    private string[] array = new string[10];
    private bool isIN = false;
    private void Start()
    {
     string[] array = new string[100];
    }

    public void setPlaylist()
    {
       if (!this.GetComponentInParent<ButtonAddPlaylist>().getState())
        {
            refreshLib();
        }
        else
        {
            StartCoroutine(waitforFrame());
        }
    }
    IEnumerator waitforFrame()
    {
        yield return new WaitUntil(() => this.GetComponentInParent<ButtonAddPlaylist>().getState());
        refreshLib();
    }
    void refreshLib()
    {


        GameObject[] Button = new GameObject[Content.transform.childCount];

        for (int counter = 0; counter < Content.transform.childCount; counter++)
        {
            Button[counter] = Content.transform.GetChild(counter).gameObject;
            if (Button[counter].transform.GetChild(1).gameObject != null)
            {
                array = Button[counter].GetComponent<Playlist>().getArray();
                for (int i = 0; i < Button[counter].GetComponent<Playlist>().getArray().Length; i++)
                {
                    if (this.GetComponentInChildren<Text>().text == array[i])
                    {
                        isIN = true;
                    }
                    else
                    {
                        Button[counter].SetActive(false);
                    }
                }

            }
            if (isIN)
            {
                Button[counter].SetActive(true);
                isIN = false;
            }
        }
        addPlayer.GetComponent<AddToPlaylist>().StopAllCoroutines();
    }
}