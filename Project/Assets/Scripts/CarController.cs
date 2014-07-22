using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour {

	private Vector3 x_plus;
	private Vector3 x_minus;
	private Vector3 z_plus;
	private Vector3 z_minus;

	private Vector3 current_direction;

	private float X1, X2;
	private float Z1, Z2;

	public float car_speed;

	private Vector3 clk;
	private int flag;
	// Use this for initialization
	void Start () {
		car_speed = 0.5f;

		x_plus = new Vector3(1, 0, 0);
		x_minus = new Vector3(-1, 0, 0);
		z_plus = new Vector3(0, 0, 1);
		z_minus = new Vector3(0, 0, -1);

		X1 = 59.8f;
		X2 = 91.4f;

		Z1 = -32.6f;
		Z2 = 52.0f;

		clk = new Vector3(0, 90, 0);

		flag = 1;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(transform.position.x+", "+transform.position.x);

		if(flag == 1){
			flag = 0;
			current_direction = x_plus;
		}
		else if(transform.position.x >= X2 && transform.position.z >= Z2){
			current_direction = z_minus;
			transform.Rotate(clk);
		}
		else if(transform.position.z <= Z1 && transform.position.x >= X2){
			current_direction = x_minus;
			transform.Rotate(clk);
		}
		else if(transform.position.x <= X1 && transform.position.z <= Z1){
			current_direction = z_plus;
			transform.Rotate(clk);
		}
		else if(transform.position.z >= Z2 && transform.position.x <= X1){
			current_direction = x_plus;
			transform.Rotate(clk);
		}

		transform.position += current_direction*car_speed;
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.name == "zhongzhong"){
			Debug.Log("Collision!!");
			other.gameObject.transform.position += new Vector3(0f,10f,5f);		
		}
	}
}
