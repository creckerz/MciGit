using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeView : MonoBehaviour
{
    public Animator MoveScreen;
    public void GoToMusic()
    {
        MoveScreen.Play("MoveUp");
    }

    public void GoToView()
    {
        MoveScreen.Play("MoveDown");
    }
}
