using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public float timer;
    public bool isPaused = false;
    public GameObject PauseMenu;
    public GameObject Health;
    void Start()
    {
        timer = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void Resume()
    {
        isPaused = false;
    }
    void Update()
    {
        Time.timeScale = timer;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }
        if (isPaused == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            PauseMenu.gameObject.SetActive(true);
            Health.gameObject.SetActive(false);
            timer = 0;
        }
        else if (isPaused == false)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            PauseMenu.gameObject.SetActive(false);
            Health.gameObject.SetActive(true);
            timer = 1;
        }
    }
}
