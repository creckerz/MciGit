using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveAudio : MonoBehaviour
{
    public string SaveTheAudio;
    
    public void savetheURL(string url)
    {
        SaveTheAudio = url;
    }
    public string getTheUrl()
    {
        return SaveTheAudio;
    }
}
