using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    public GameObject settings;
    public GameObject MenuMessage;
    public GameObject QuitMessage;
    public void SettingsWindow()
    {
        settings.SetActive(!settings.activeSelf);
        MenuMessage.SetActive(!QuitMessage.activeSelf && !settings.activeSelf && MenuMessage.activeSelf);
        QuitMessage.SetActive(QuitMessage.activeSelf && !settings.activeSelf && !MenuMessage.activeSelf);
    }
    public void QuitWindow()
    {
        QuitMessage.SetActive(!QuitMessage.activeSelf);
        settings.SetActive(!QuitMessage.activeSelf && settings.activeSelf && !MenuMessage.activeSelf);
        MenuMessage.SetActive(!QuitMessage.activeSelf && !settings.activeSelf && MenuMessage.activeSelf);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void MenuWindow()
    {
        MenuMessage.SetActive(!MenuMessage.activeSelf);
        settings.SetActive(!QuitMessage.activeSelf && settings.activeSelf && !MenuMessage.activeSelf);
        QuitMessage.SetActive(QuitMessage.activeSelf && !settings.activeSelf && !MenuMessage.activeSelf);
    }
    public void Menu()
    {
        SceneManager.LoadScene(5);
    }
}
