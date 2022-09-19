using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteFiles : MonoBehaviour
{
    public GameObject Content;
    public void delete()
    {
        GameObject[] Button = new GameObject[Content.transform.childCount];

        for (int counter = 1; counter < Content.transform.childCount; counter++)
        {
            Button[counter] = Content.transform.GetChild(counter).gameObject;
            if (Button[counter].transform.GetChild(1).gameObject != null)
            {
                if (Button[counter].transform.GetChild(1).GetComponent<Toggle>().isOn)
                {
                    Destroy(Button[counter]);
                }
            }
        }
    }
}
