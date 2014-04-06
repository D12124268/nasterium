
using UnityEngine;
using System.Collections;

public class RayScript: MonoBehaviour {
	float hoverHeight = 5;
	float hoverHeightStrictness = 0.5f;

	float bankAmount = 3.7f; //0.1
	float bankSpeed = 0.3f;  //0.2
	Vector3 bankAxis = new Vector3(0.0f, 0.0f, -1.0f); //-1,0,0
	float turnSpeed = 20.0f; //20
	
	public GameObject Cube; //new
	Vector3 CubeDirection = new Vector3(0,0,0);
	
	Vector3 forwardDirection = Vector3.forward;
	
	//float mass = 1.0f;
	
	
	bool  playerControl = true;
	
	private float bank = 0.0f;
	// /*
	// positional drag
	float sqrdSpeedThresholdForDrag = 25.0f;
	float superDrag = 2.0f;
	float fastDrag = 0.5f;
	float slowDrag = 0.01f;
	
	// angular drag
	float sqrdAngularSpeedThresholdForDrag = 5.0f;
	float superADrag = 32.0f;
	float fastADrag = 16.0f;
	float slowADrag = 0.1f;
	// */
	
	
	
	void  SetPlayerControl ( bool control  ){
		playerControl = control;
	}
	
	
	void  Start (){
		// gameObject.rigidbody.mass = mass;
	}
	
	void  FixedUpdate (){
		//gameObject.rigidbody.mass = mass;
		// /*
		if (Mathf.Abs(thrust) > 0.01f)
		{
			if (rigidbody.velocity.sqrMagnitude > sqrdSpeedThresholdForDrag)
				rigidbody.drag = fastDrag;
			else
				rigidbody.drag = slowDrag;
		}
		else
			rigidbody.drag = superDrag;
		
		if (Mathf.Abs(turn) > 0.01f)
		{
			if (rigidbody.angularVelocity.sqrMagnitude > sqrdAngularSpeedThresholdForDrag)
				rigidbody.angularDrag = fastADrag;
			else
				rigidbody.angularDrag = slowADrag;
		}
		else
			rigidbody.angularDrag = superADrag;
		// */
		
		transform.position = Vector3.Lerp(transform.position, new Vector3(Cube.transform.position.x, Cube.transform.position.y + hoverHeight, transform.position.z), hoverHeightStrictness); //lerp back to hover hieght

		//transform.rotation = Quaternion.Lerp(transform.rotation, Cube.transform.rotation, 2);

		float amountToBank = rigidbody.angularVelocity.y * bankAmount;
		
		bank = Mathf.Lerp(bank, amountToBank, bankSpeed);
		
		Vector3 rotation = transform.rotation.eulerAngles;
		rotation *= Mathf.Deg2Rad;
		rotation.x = 0;
		rotation.z = 0;
		rotation += bankAxis * bank;
		rotation *= Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(rotation);
		
	}
	
	// thrust
	private float thrust = 0;
	private float turn = 0;
	
	void  Thrust (  float t   ){
		thrust = Mathf.Clamp( t, -1.0f, 1.0f );
	}
	
	void  Turn ( float t  ){
		turn = Mathf.Clamp( t, -1.0f, 1.0f ) * turnSpeed; //look here
	}
	
	private bool  thrustGlowOn = false;
	
	void  Update (){
		float theThrust = thrust;
		
		if (playerControl)
		{
			thrust = Input.GetAxis("Vertical");
			turn = Input.GetAxis("Horizontal") * turnSpeed;
		}
		

		
		rigidbody.AddRelativeTorque(Vector3.up * turn * Time.deltaTime);
		rigidbody.AddRelativeForce(forwardDirection * theThrust * Time.deltaTime);
	}
}