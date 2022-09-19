using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Favorites : MonoBehaviour
{
    bool fav = false;
    public GameObject FavOn, FaveOff;

    public void favorite()
    {
        fav = !fav;
        FavOn.SetActive(fav);
        FaveOff.SetActive(!fav);
    }
}
