using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject playButton;
    public GameObject textHost;
    public GameObject textPort;
    public GameObject launchButton;

    public void Play()
    {
        textHost.SetActive(true);
        textPort.SetActive(true);
        launchButton.SetActive(true);
        playButton.SetActive(false);
    }

    public void Launch()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void Quit()
    {
        Application.Quit();
    }

    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
