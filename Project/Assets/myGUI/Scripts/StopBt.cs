using UnityEngine;
using System.Collections;

public class StopBt : MonoBehaviour {

	public GameObject StopMenu = GameObject.Find("StopMenu");

	void OnClick()
	{
		StopMenu.SetActive (true);
		}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
