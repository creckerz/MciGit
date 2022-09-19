using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[RequireComponent(typeof(AudioSource))]
public class Play : MonoBehaviour
{
    string Name, saveName, savePath;
    float lenght;

    AudioSource audioSource;
    public string soundPath;
    bool stop;
    private void Start()
    {
        stop = false;
    }
    public void stopSong()
    {
        if (stop)
        {
            audioSource.Stop();
            stop = false;
        }
        else
        {
            //audioSource.Play();
            PlaySong(getPath(), getName());
            stop = true;
        }
        
    }
    public void PlaySong(string SoundPath, string audioName)
    {
        setaudioName(audioName);
        setaudioPath(SoundPath);
        soundPath = SoundPath;
        audioSource = this.GetComponent<AudioSource>();
        StartCoroutine(UpdateLib(audioName));
    }

    private IEnumerator UpdateLib(string audioName)
    {
        soundPath = string.Format("file://" +  soundPath);
         //soundPath = soundPath.Replace("\\", "/");
        Debug.Log(soundPath);
        WWW url = new WWW(soundPath);
        yield return url;

        audioSource.clip = NAudioPlayer.FromMp3Data(url.bytes);
        audioSource.Play();
        Name = audioName;
        Debug.Log(Name);
        lenght = audioSource.clip.length;
        Debug.Log(lenght);
        stop = true;

    }
    private void setaudioPath(string audioPath)
    {
        savePath = audioPath;
    }
    private string getPath()
    {
        return savePath;
    }
    private void setaudioName(string audioName)
    {
        saveName = audioName;
    }
    private string getName()
    {
        return saveName;
    }

}
