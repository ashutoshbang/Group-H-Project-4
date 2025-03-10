﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PopupHandler : MonoBehaviour
{
    public static int scene = 0;
    public GameObject panel, back, next;
    private Text Message, NextText, BackText;
    private string[] s = {
        "Hello! Let's get started with our 1st Mission!PLANTATION",
        "Look at the mountain/peaks to find highlighted region.",
        "You can go to the highlighted region to plant trees on that mountain.",
        "You can only chose one among the two mountains.",
        "You have to detect where landslide could occur.",
        "Look at the mountains on your sides.",
        "You're All Set... Goodluck!!!",""
    };

    private static int i;
    void Start()
    {
        i = 0;
        scene = 0;
        Message = GameObject.Find("Message").GetComponent<Text>();
        NextText = next.GetComponentInChildren<Text>();
        BackText = back.GetComponentInChildren<Text>();
        NextText.text = "NEXT";
        BackText.text = "BACK";
        Message.text = s[i];
        next.GetComponent<Button>().onClick.AddListener(Next);
        back.GetComponent<Button>().onClick.AddListener(Back);
    }
    void Next()
    {
        i++;
        if (i == 8)
        {
            scene = 1;
            SceneManager.LoadScene(7);
            return;
        }
        GameGuide(i);
    }
    void Back()
    {
        i--;
        if (i < 0)
            i = 0;
        else if (i == 6)
        {
            SceneManager.LoadScene(1);
            return;
        }
        GameGuide(i);
    }
    void GameGuide(int j)
    {
        Message.text = s[j];
        if (j == 6)
        {
            NextText.text = "START";
            back.SetActive(false);
        }
        else if (j == 7)
        {
            panel.SetActive(false);
            back.SetActive(true);
            NextText.text = "FINISH";
            BackText.text = "RETRY";
        }
    }
}
