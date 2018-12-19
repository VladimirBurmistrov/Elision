using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

    public GameObject zombie1;
    public GameObject zombie2;
    public GameObject zombie3;
    public GameObject zombie4;
    public GameObject zombie5;
    public GameObject zombie6;
    public GameObject zombie7;
    public GameObject zombie8;
    public GameObject zombie9;
    public GameObject zombie10;
    public GameObject zombie11;
    public GameObject zombie12;
    public GameObject TheEnd;

    void OnTriggerEnter(Collider TP)
    {
        if (TP.attachedRigidbody)
        {
            zombie1.SetActive(true);
            zombie2.SetActive(true);
            zombie3.SetActive(true);
            zombie4.SetActive(true);
            zombie5.SetActive(true);
            zombie6.SetActive(true);
            zombie7.SetActive(true);
            zombie8.SetActive(true);
            zombie9.SetActive(true);
            zombie10.SetActive(true);
            zombie11.SetActive(true);
            zombie12.SetActive(true);
            TheEnd.SetActive(true);
        }
    }
}
