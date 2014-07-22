using UnityEngine;
using System.Collections;

public class BoardControl : MonoBehaviour {

	private Vector3 x_plus;

	private Vector3 current_direction;

	public float car_speed;
	private float flag = 0;

	// Use this for initialization
	void Start () {
		car_speed = 0.01f;

		x_plus = new Vector3(1, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(transform.position.x+", "+transform.position.x);

		current_direction = x_plus;

		transform.position += current_direction*car_speed;
		if(flag != 0){
			
			GameObject.Find("zhongzhong").transform.position += current_direction*car_speed;
		}
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.name == "zhongzhong"){
			Debug.Log("Collision!!");
			other.gameObject.transform.position = transform.position;
			flag = 1;

		}
	}
}
