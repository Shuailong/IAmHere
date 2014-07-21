using UnityEngine;
using System.Collections;
using System;

public class RePlay : MonoBehaviour {
	public GameObject StopButton = GameObject.Find("StopButton");
	public GameObject TimeLabel= GameObject.Find ("TimeLabel");
	public GameObject TimeSprite= GameObject.Find ("TimeSprite");
	public GameObject StartButton= GameObject.Find ("StartButton");
	public GameObject duanxin = GameObject.Find ("duanxin");

	void OnClick()
	{
		Application.LoadLevel ("try4");
		        StartButton.SetActive (false);
			//	StopButton.SetActive (true);
				TimeLabel.SetActive (true);
				TimeSprite.SetActive (true);
				duanxin.SetActive (true);
		}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
