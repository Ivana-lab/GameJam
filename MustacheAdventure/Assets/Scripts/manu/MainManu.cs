using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainManu : MonoBehaviour
{
    public Button startButton;
    public Button exitButton;

    public GameObject startBar;
    public void Awake()
    {
        startButton.onClick.AddListener(start);
        exitButton.onClick.AddListener(exit);
    }

    // Start is called before the first frame update
    public void start()
    {
        startBar.SetActive(true);
    }

    public void exit()
    {
        Debug.Log("Quit.");
        Application.Quit();
    }
}
