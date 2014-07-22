using UnityEngine;
using System.Collections;

public class music : MonoBehaviour {
	public AudioSource player_footsteps;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//target = GameObject.Find("B_Boy_Player");
		if(Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.UpArrow)||Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.DownArrow)
		   ||Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.D))
			audio.Play();
		else if(player_footsteps.isPlaying)//player_footsteps
			audio.Stop();
	
	}
}
