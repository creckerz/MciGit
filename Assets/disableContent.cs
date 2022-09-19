using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableContent : MonoBehaviour
{
    public GameObject Content;
    public void changeContentState(bool changeState)
    {
        Content.SetActive(changeState);
    }
}
