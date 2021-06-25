using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings : MonoBehaviour
{

    public GameObject menu;
    public GameObject ButtonMenu;

    public void Quit()
    {
        Application.Quit();
    }

    public void Menu()
    {
        menu.SetActive(true);
        ButtonMenu.SetActive(false);
    }

    public void Back()
    {
        menu.SetActive(false);
        ButtonMenu.SetActive(true);
    }
}
