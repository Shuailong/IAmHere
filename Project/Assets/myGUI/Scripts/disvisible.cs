using UnityEngine;
using System.Collections;
using System;

public class disvisible : MonoBehaviour {
	public GameObject StopButton= GameObject.Find ("StopButton");
	public GameObject StopMenu= GameObject.Find ("StopMenu");
	public GameObject TimeLabel= GameObject.Find ("TimeLabel");
	public GameObject TimeSprite= GameObject.Find ("TimeSprite");
	public GameObject duanxin = GameObject.Find ("duanxin");
	public GameObject LoseMenu = GameObject.Find("LoseMenu");
	public GameObject WinMenu = GameObject.Find("WinMenu");


	// Use this for initialization
	void Start () {
		Time.timeScale = 0;
		StopButton.SetActive (false);
		StopMenu.SetActive (false);
		TimeLabel.SetActive (false);
		TimeSprite.SetActive (false);
		duanxin.SetActive (false);
		LoseMenu.SetActive (false);
		WinMenu.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
