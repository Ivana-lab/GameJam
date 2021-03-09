using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TeleporterEnd : MonoBehaviour
{
    public GameObject endPanel;
    public GameObject continuePanel;
    
    public Button continueButton;
    public Button quitButton;

    private void Awake()
    {
        continueButton.onClick.AddListener(EndPanel);
        quitButton.onClick.AddListener(QuitGame);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerMove pl = collision.gameObject.GetComponent<PlayerMove>();
        if (pl != null)
        {
            continuePanel.SetActive(true);
        }
    }

    public void EndPanel()
    {
        continuePanel.SetActive(false);
        endPanel.SetActive(true);
    }

    public void QuitGame()
    {
        Debug.Log("EndGame");
        Application.Quit();
    }
}
