using UnityEngine;
using System.Collections;
using System;

public class timeDisplay : MonoBehaviour {
	public GameObject LoseMenu = GameObject.Find ("LoseMenu");
	public UILabel Label_Name = null;
	
	public int endTime;
	public int currentTime;
	public int startTime;
	public int second;
	public int minute;
	private string printTime;
	private string stringEndTime;
	int i;
	// Use this for initialization
	
	
	void Start () {
		startTime = 240;  
		i = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
		endTime = startTime - currentTime;
		if(endTime<=0)
		{   
			if(i==0)
			{Time.timeScale = 0;
				LoseMenu.SetActive(true);}
			i=1;
			endTime = 0;

		}
		//endTime = currentTime;
		second = endTime % 60;
		minute = endTime / 60;
		currentTime = Mathf.CeilToInt(Time.fixedTime);
		if(second<10)
		{printTime = ":0";
		}else{printTime = ":";}
		stringEndTime = "00:0" + minute + printTime + second;
		//print ("00:0" + minute + printTime + second);
		//print(stringEndTime);

		
		
		Label_Name.text = stringEndTime;//DateTime.Now.ToString("hh:mm:ss");
		
	}
}
