using UnityEngine;
using System.Collections;

enum WellState{
	down = 0, 
	up = 1,
	normal = 2
}

public class WellStrigger : MonoBehaviour {
	private WellState state;
	private GameObject target;
	private float startTime;
	private float currentTime;

	void Start(){
		state = WellState.normal;
		startTime = -1f;
	}

	void Update(){
		//Debug.Log("currentTime:" + currentTime + ", startTime: " + startTime + ",state: " + state);
	
		currentTime = Time.time;

		if(startTime != -1 && state == WellState.down && currentTime - startTime > 5){
			state = WellState.up;
		}

		if(state == WellState.up){
			target = GameObject.Find("zhongzhong");
			target.transform.position += new Vector3(10f,35f,10f);
			Debug.Log("Ok");
			state = WellState.normal;
		}
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.name == "zhongzhong"){	
			state = WellState.down;
			startTime = Time.time;
			other.gameObject.transform.position += new Vector3(0f,-10f,0f);	
		}
	}
}
