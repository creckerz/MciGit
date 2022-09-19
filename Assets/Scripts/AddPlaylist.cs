using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddPlaylist : MonoBehaviour
{
    string Text;
    Text gotext;
    public GameObject addPlaylst, parent, newObject;
    TouchScreenKeyboard SaveInput;
    //GameObject newPlaylist;
    public void AddPlayLists()
    {

#if PLATFORM_ANDROID
        SaveInput = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, false, true, false, false, "Default", 10);
        StartCoroutine(waitTillFin());
#endif
    }

    IEnumerator waitTillFin()
    {

        yield return new WaitUntil(() => SaveInput.status == TouchScreenKeyboard.Status.Done || SaveInput.status == TouchScreenKeyboard.Status.Canceled);
        if(SaveInput.status == TouchScreenKeyboard.Status.Done) 
        {
            Text = SaveInput.text;
            newObject = GameObject.Instantiate(addPlaylst, parent.transform);
            newObject.name = Text;
            Text NewText = newObject.GetComponentInChildren<Text>();
            NewText.text = Text;
        }


    }
}