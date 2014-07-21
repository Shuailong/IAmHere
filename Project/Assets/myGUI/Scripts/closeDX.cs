using UnityEngine;
using System.Collections;

public class closeDX : MonoBehaviour {

	public GameObject duanxin = GameObject.Find("duanxin");
	public GameObject StopBt = GameObject.Find("StopButton");
	void OnClick()
	{
		duanxin.SetActive (false);
		StopBt.SetActive (true);
		}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
