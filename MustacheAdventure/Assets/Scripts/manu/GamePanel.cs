using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GamePanel : MonoBehaviour
{
    public Button closeButton;
    public Button charButton;
    public Button lockedButton;
    public Button lockedButton2;
    public Button tutorialButton;
    public Button getTutorialButton;

    public GameObject panel;
    public GameObject lockedPanel;
    public GameObject tutorialPanel;
    public GameObject storyPanel;
    public GameObject storyPanel2;

    public string gamePlay;

    public void Awake()
    {
        closeButton.onClick.AddListener(closePanel);
        lockedButton.onClick.AddListener(FlockedPanel);
        lockedButton2.onClick.AddListener(FlockedPanel);
        charButton.onClick.AddListener(StoryPanel);
        getTutorialButton.onClick.AddListener(TutorialPanel);
        tutorialButton.onClick.AddListener(startGame);
       
    }

    public void FlockedPanel()
    {
        lockedPanel.SetActive(true);
    }

    public void StorylPanel()
    {
        storyPanel.SetActive(true);
        Invoke("StoryPanel", 3f);
    }

    public void StoryPanel()
    {
        storyPanel.SetActive(false);
        storyPanel2.SetActive(true);
    }

    public void TutorialPanel()
    {
        storyPanel2.SetActive(false);
        tutorialPanel.SetActive(true);
    }


    public void startGame()
    {
        SceneManager.LoadScene(gamePlay);
    }

    public void closePanel()
    {
        panel.SetActive(false);
    }
}
