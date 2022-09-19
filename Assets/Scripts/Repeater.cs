using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repeater : MonoBehaviour
{
    int i = 2;
    public GameObject repeat, loop, none;

    public void nextState()
    {
        i++;
        if (i > 2) i = 0;
        switch (i)
        {
            case 0:
                none.SetActive(false);
                loop.SetActive(true);
                break;
            case 1:
                loop.SetActive(false);
                repeat.SetActive(true);
                break;
            case 2:
                repeat.SetActive(false);
                none.SetActive(true);
                break;
        }

    }
}
