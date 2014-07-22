using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {
	public GameObject StopButton = GameObject.Find("StopButton");
	public GameObject TimeLabel= GameObject.Find ("TimeLabel");
	public GameObject TimeSprite= GameObject.Find ("TimeSprite");
	public GameObject StartButton= GameObject.Find ("StartButton");
	public GameObject duanxin = GameObject.Find ("duanxin");

	void OnClick(){
	//	StopButton.SetActive (true);
		TimeLabel.SetActive (true);
		TimeSprite.SetActive (true);
		StartButton.SetActive (false);
		duanxin.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
