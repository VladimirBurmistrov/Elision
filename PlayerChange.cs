using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PlayerChange : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player1afk;
    public GameObject Player2afk;
    public GameObject Camera1;
    public GameObject Camera2;
    private string Save;
    private float Check;
    void Start()
    {
        Save = "Saves/Player.txt";
        using (StreamReader streamReader = new StreamReader("Saves/Player.txt"))
        {
            if (streamReader != null)
            {
                string Check = streamReader.ReadToEnd();
                if (Check != "0")
                {
                    if (Check == "1")
                    {
                        Player1afk.SetActive(false);
                    }
                    else if (Check == "2")
                    {
                        Player2afk.SetActive(false);
                    }
                }
                else
                {
                    Player1afk.SetActive(false);
                }
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        using (StreamReader streamReader = new StreamReader("Saves/Player.txt"))
        {
            if (streamReader != null)
            {
                string Check = streamReader.ReadToEnd();
                {
                    if (Check != "0")
                    {
                        if (Check == "1")
                        {
                            Player1.SetActive(false);
                            Player2.transform.position = Player1afk.transform.position + new Vector3(0, 0, -3);
                            Player2.SetActive(true);
                            Player1afk.SetActive(true);
                            Player2afk.SetActive(false);
                            Camera1.SetActive(false);
                            Camera2.SetActive(true);
                            Debug.Log("Save " + 2);
                            FileStream sb = new FileStream("Saves/Player.txt", FileMode.OpenOrCreate);
                            StreamWriter sw = new StreamWriter(sb);
                            sw.Write(2);
                            sw.Close();
                        }
                        else if (Check == "2")
                        {
                            Player2.SetActive(false);
                            Player1.transform.position = Player2afk.transform.position + new Vector3(0, 0, -3);
                            Player1.SetActive(true);
                            Player2afk.SetActive(true);
                            Player1afk.SetActive(false);
                            Camera1.SetActive(true);
                            Camera2.SetActive(false);
                            Debug.Log("Save " + 1);
                            FileStream sb = new FileStream("Saves/Player.txt", FileMode.OpenOrCreate);
                            StreamWriter sw = new StreamWriter(sb);
                            sw.Write(1);
                            sw.Close();
                        }
                    }
                }
            }
        }
    }
}