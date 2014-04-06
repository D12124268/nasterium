
using UnityEngine;
using System.Collections;

public class fireBall : MonoBehaviour {

	public float direction = 0.0f;
	public float speed = 0.1f;
	public int force = 5000;
	
	// Update is called once per frame
	void Update () 
	{
		//Debug.Log (Input.GetAxis ("Vertical"));
		direction = Input.GetAxis ("Vertical");
		transform.position += Vector3.up * speed *  direction ;
		
		if (Input.GetButton("Jump"))
		{
			force += 100;
		}
		if (Input.GetButtonUp("Jump"))
		{
			Debug.Log("Jump Pressed");
			rigidbody.AddForce(Vector3.right* force);
			rigidbody.useGravity = true;
			force = 0;
		}
	}
}
