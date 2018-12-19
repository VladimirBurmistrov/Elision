using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scener : MonoBehaviour
{
    [Header("Загружаемая сцена")]
    public int sceneID;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            SceneManager.LoadScene(sceneID);
        }
    }
}
