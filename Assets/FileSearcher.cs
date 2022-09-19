using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Android;
using System.Threading.Tasks;


public class FileSearcher : MonoBehaviour
{
    private string start, path;
    public GameObject setAudios, parent, addTrack;
    private GameObject newObject;
    private GameObject[] Button;
    string[] subpath;
    GameObject dialog = null;
    public GameObject Text;
    //public UnityEngine.UI.RawImage _UiRawImage;

    private void Start()
    {
        start = Application.dataPath;
        Permission.RequestUserPermission(Permission.ExternalStorageWrite);
    }
    public void refreshLib()
    {

#if UNITY_ANDROID
        if (!Permission.HasUserAuthorizedPermission(Permission.ExternalStorageRead))
        {
            Permission.RequestUserPermission(Permission.ExternalStorageRead);
            dialog = new GameObject();
        }
        var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        path = documentsPath;
#endif
#if !UNITY_ANDROID
        path = Path.GetPathRoot(start);
#endif
        StartCoroutine(searchFile(path));

    }

    public IEnumerator searchFile(string path)
    {
#if UNITY_ANDROID
        if (!Permission.HasUserAuthorizedPermission(Permission.ExternalStorageRead))
                {
                    yield return dialog;
                }
                else if (dialog != null)
                {
                    Destroy(dialog);
                }
#endif
            foreach (string mp3 in Directory.EnumerateFiles(path, "*.mp3", SearchOption.TopDirectoryOnly))
            {
                try
                {
                    newObject = GameObject.Instantiate(addTrack, parent.transform);
                    newObject.name = Path.GetFileName(mp3);
                    Text NewText = newObject.GetComponentInChildren<Text>();
                    NewText.text = Path.GetFileName(mp3);
                    newObject.GetComponent<SaveAudio>().savetheURL(mp3);
                    WWW www = new WWW(mp3);
                    if (www.textureNonReadable.isReadable)
                    {
                        UnityEngine.UI.RawImage _UiRawImage;
                        Texture2D texture = new Texture2D(1, 1);
                        www.LoadImageIntoTexture(texture);
                        newObject.GetComponentInChildren<RawImage>().texture = texture;

                    }
                    newObject.SetActive(true);
                }
                catch (Exception ex) { /*Debug.Log(ex);*/ }
            yield return mp3;
            }
            foreach (string subfolder in Directory.GetDirectories(path))
            {
            Text.GetComponent<Text>().text = subfolder;
                try
                {
                    StartCoroutine(searchFile(subfolder));
                }
                catch (Exception ex) { }
                yield return subfolder;
        }
        yield return path;
    }
}
