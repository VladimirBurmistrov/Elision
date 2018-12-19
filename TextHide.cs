using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextHide : MonoBehaviour
{
    public GameObject text;
    void OnTriggerEnter(Collider TP)
    {
        if (TP.attachedRigidbody)
        {
            text.SetActive(false);
        }
    }
}
