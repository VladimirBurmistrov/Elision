using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SurfaceTP : MonoBehaviour
{
    public int sceneID;
    void OnTriggerEnter(Collider TP)
    {
        if (TP.attachedRigidbody)
        {
            SceneManager.LoadScene(sceneID);
        }
    }
}
