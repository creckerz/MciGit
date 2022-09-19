using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeTheme : MonoBehaviour
{
    public Material text, backGround, Button;
    public new Text light;
    public Animator restart;

    public void Start()
    {
        if(text.color == new Color32(255, 255, 255, 255))
        {
            light.text = "dark";
        }
    }
    public void changeFont()
    {
        if (light.text == "dark")
        {
            text.color = new Color32(0, 0, 0, 255);
            backGround.color = new Color32(255, 255, 255, 150);
            Button.color = new Color32(0, 0, 0, 255);
            light.text = "light";
        }
        else
        {
            text.color = new Color32(255, 255, 255, 255);
            backGround.color = new Color32(0, 0, 0, 255);
            Button.color = new Color32(255, 255, 255, 255);
            light.text = "dark";
        }
        restart.Play("GoIn");

    }
}