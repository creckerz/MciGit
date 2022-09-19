using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisablePlayer : MonoBehaviour
{
    public GameObject PlayerBtn, PlayBtn;
    private bool change = true;
    public void editmode()
    {
        change = !change;
        if (!change)
        {
            PlayerBtn.SetActive(false);
            PlayBtn.SetActive(false);
        }

        if (change)
        {
            PlayerBtn.SetActive(true);
            PlayBtn.SetActive(true);
        }
    }

}
