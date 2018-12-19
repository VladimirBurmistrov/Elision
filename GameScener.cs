using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScener : MonoBehaviour
{
    [Header("Загружаемая сцена")]
    public int sceneID;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene(sceneID);
        }
    }
}
