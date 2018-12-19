using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ChoosePlayer : MonoBehaviour {
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Camera1;
    public GameObject Camera2;
    private float Check;
    void Start () {
        StreamReader streamReader = new StreamReader("Saves/Player.txt");
        if (streamReader != null)
        {
            while (!streamReader.EndOfStream)
            {
                Check = System.Convert.ToSingle(streamReader.ReadLine());
            }
            if (Check != 0)
            {
                if (Check == 1)
                {
                    Player1.SetActive(true);
                    Camera1.SetActive(true);
                }
                else if (Check == 2)
                {
                    Player2.SetActive(true);
                    Camera2.SetActive(true);
                }
            }
            else
            {
                Player1.SetActive(true);
                Camera1.SetActive(true);
            }
        }
    }
}
