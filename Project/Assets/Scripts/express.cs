using UnityEngine;
using System.Collections;

public class express : MonoBehaviour {

	Vector3[] positions;
	int index;	
	System.Random r;

	// Use this for initialization
	void Start () {
		positions = new Vector3[5];
		positions[0] = new Vector3(-312f, -25f, 22.7f);
		positions[1] = new Vector3(-25f, -22f, 141.7f);
		positions[2] = new Vector3(180f, -18f, 273f);
		positions[3] = new Vector3(109f, -18f, -19.17f);
		positions[4] = new Vector3(312f, -18f, 22f);	

		r = new System.Random();
		//index = r.Next(0, 5);
		index = 1;

		transform.position = positions[index];
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(index);
	}

	void OnClick(){
		// Game pause
		// Show end UI.		
	}
}
