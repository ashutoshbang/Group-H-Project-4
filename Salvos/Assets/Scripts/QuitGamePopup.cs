﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuitGamePopup : MonoBehaviour {
	public GameObject QuitPanel, YButton, RButton;
	// Use this for initialization
	void Start () {
		YButton.GetComponent<Button>().onClick.AddListener(Quit);
		RButton.GetComponent<Button>().onClick.AddListener(Resume);
		QuitPanel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Escape)){
			QuitPanel.SetActive(true);
		}
	}

	public void Resume(){
		QuitPanel.SetActive(false);
	}

	public void Quit(){
        GameManager.scene = 0;
        PopupHandler.scene = 0;
        Mission2PopupHandler.scene = 0;
        GameScript.scene = 0;
		SceneManager.LoadScene(6);
	}
}
