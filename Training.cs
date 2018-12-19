using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Training : MonoBehaviour
{
    public GameObject tr1;
    public GameObject tr2;
    public GameObject tr3;
    public GameObject tr4;
    public GameObject tr5;
    public GameObject tr6;
    public GameObject tr7;
    public GameObject training;
    private int i;

    void Start()
    {
        i = 1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && i < 7)
        {
            i++;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && i > 1)
        {
            i--;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            training.SetActive(!training.activeSelf);
        }
        switch (i)
        {
            case 1:
                tr1.SetActive(true);
                tr2.SetActive(false);
                tr3.SetActive(false);
                tr4.SetActive(false);
                tr5.SetActive(false);
                tr6.SetActive(false);
                tr7.SetActive(false);
                break;
            case 2:
                tr1.SetActive(false);
                tr2.SetActive(true);
                tr3.SetActive(false);
                tr4.SetActive(false);
                tr5.SetActive(false);
                tr6.SetActive(false);
                tr7.SetActive(false);
                break;
            case 3:
                tr1.SetActive(false);
                tr2.SetActive(false);
                tr3.SetActive(true);
                tr4.SetActive(false);
                tr5.SetActive(false);
                tr6.SetActive(false);
                tr7.SetActive(false);
                break;
            case 4:
                tr1.SetActive(false);
                tr2.SetActive(false);
                tr3.SetActive(false);
                tr4.SetActive(true);
                tr5.SetActive(false);
                tr6.SetActive(false);
                tr7.SetActive(false);
                break;
            case 5:
                tr1.SetActive(false);
                tr2.SetActive(false);
                tr3.SetActive(false);
                tr4.SetActive(false);
                tr5.SetActive(true);
                tr6.SetActive(false);
                tr7.SetActive(false);
                break;
            case 6:
                tr1.SetActive(false);
                tr2.SetActive(false);
                tr3.SetActive(false);
                tr4.SetActive(false);
                tr5.SetActive(false);
                tr6.SetActive(true);
                tr7.SetActive(false);
                break;
            case 7:
                tr1.SetActive(false);
                tr2.SetActive(false);
                tr3.SetActive(false);
                tr4.SetActive(false);
                tr5.SetActive(false);
                tr6.SetActive(false);
                tr7.SetActive(true);
                break;
            default:
                tr1.SetActive(true);
                tr2.SetActive(false);
                tr3.SetActive(false);
                tr4.SetActive(false);
                tr5.SetActive(false);
                tr6.SetActive(false);
                tr7.SetActive(false);
                break;
        }
    }
}
