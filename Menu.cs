using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class Menu : MonoBehaviour
{
    public GameObject settings;
    public GameObject AboutButton;
    public GameObject message;
    private string Save;
    void Start()
    {
        Save = "Saves/Player.txt";
    }
    void Update()
    {
        Time.timeScale = 1f;
    }
    public void NewGame()
    {
        StreamWriter sw = new StreamWriter(Save);
        sw.Write(1);
        sw.Close();
        SceneManager.LoadScene(1);
    }
    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }
    public void SettingsWindow()
    {
        settings.SetActive(!settings.activeSelf);
        AboutButton.SetActive(!message.activeSelf && !settings.activeSelf && AboutButton.activeSelf);
        message.SetActive(message.activeSelf && !settings.activeSelf && !AboutButton.activeSelf);
    }
    public void AboutWindow()
    {
        AboutButton.SetActive(!AboutButton.activeSelf);
        settings.SetActive(!message.activeSelf && settings.activeSelf && !AboutButton.activeSelf);
        message.SetActive(message.activeSelf && !settings.activeSelf && !AboutButton.activeSelf);
    }
    public void QuitMessage()
    {
        message.SetActive(!message.activeSelf);
        AboutButton.SetActive(!message.activeSelf && !settings.activeSelf && AboutButton.activeSelf);
        settings.SetActive(!message.activeSelf && settings.activeSelf && !AboutButton.activeSelf);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
