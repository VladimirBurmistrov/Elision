using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawn : MonoBehaviour {
    public GameObject zombie1;
    public GameObject zombie2;
    public GameObject zombie3;
    void Start()
    {
        zombie1.SetActive(false);
        zombie2.SetActive(false);
        zombie3.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        zombie1.SetActive(true);
        zombie2.SetActive(true);
        zombie3.SetActive(true);
    }
}
