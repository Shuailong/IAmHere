using UnityEngine;
using System.Collections;

public class StrButton : MonoBehaviour {
	public GameObject StopMenu = GameObject.Find("StopMenu");
	
	void OnClick()
	{
		StopMenu.SetActive (false);
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
