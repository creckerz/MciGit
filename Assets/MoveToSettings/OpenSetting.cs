using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSetting : MonoBehaviour
{
    public Animator GoToSettings;
    public void GoToSetting()
    {
        GoToSettings.Play("GoToSettings");
    }

    public void GoToView()
    {
        GoToSettings.Play("LeaveSettings");
    }

    public void GoToPlaylist()
    {
        GoToSettings.Play("GoToPlayList");
    }

    public void LeavePlaylist()
    {
        GoToSettings.Play("LeavePlaylist");
    }
}
