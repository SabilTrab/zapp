using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    [SerializeField] Slider voulmeslider;

    void Start()
    {
        if(!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        else
            Load();
    }

    public void VolumeChange()
    {
        AudioListener.volume = voulmeslider.value;
        Save();
    }

    private void Load()
    {
        voulmeslider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", voulmeslider.value);
    }
}
