using UnityEngine;
using System.Collections;

public class moveLeftRight : MonoBehaviour {
	
	public float speed = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () { //FixedUpdate best for physics
		Vector3 force = new Vector3 (0,0,1) * Input.GetAxis("Horizontal"); //creates a vector that moves to the rigth (normally 1,0,0)
		rigidbody.AddForce(force, ForceMode.VelocityChange);
		//Vector3 force = new Vector3 (1,0,0) * Input.GetAxis("Vertical"); //creates a vector that moves to the rigth (normally 1,0,0)
		//rigidbody.AddForce(force, ForceMode.VelocityChange);
		
	}
}
