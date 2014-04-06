 /*
using UnityEngine;
using System.Collections;

public class HoverRacing : MonoBehaviour {

	public float hoverHeight = 3.0f;
	public float hoverHeightStrictness = 1.0f;
	public float  forwardThrust = 5000.0f;
	public float  backwardThrust = 2500.0f;
	public float  bankAmount = 0.1f;
	public float bankSpeed = 0.2f;
	public Vector3 bankAxis  = new Vector3(-1.0f, 0.0f, 0.0f);
	public float turnSpeed = 2.0f;
	public float	bank = 0.0f;

	public float thrust = 0.0f;
	public float turn = 0.0f;
	
	Vector3  forwardDirection = new Vector3(0.0f, 0.0f, 1.0f);

	// Use this for initialization
	void Start () {
	
	}

	void FixedUpdate(){

		transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, hoverHeight, transform.position.z), hoverHeightStrictness); //lerp back to hover hieght
		
		float amountToBank  = rigidbody.angularVelocity.y * bankAmount;
		
		bank = Mathf.Lerp(bank, amountToBank, bankSpeed);
		
		Vector3 rotation = transform.rotation.eulerAngles;
		rotation *= Mathf.Deg2Rad;
		rotation.x = 0;
		rotation.z = 0;
		rotation += bankAxis * bank;
		rotation *= Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(rotation);
	}

	 void function Thrust( float t )
	{
		thrust = Mathf.Clamp( t, -1.0, 1.0 );
	}

	void function Turn(float t)
	{
		turn = Mathf.Clamp( t, -1.0, 1.0 ) * turnSpeed; //look here
	}

	// Update is called once per frame
	void Update () {
		//transform.position += transform.forward * Time.deltaTime * 90.0f;
		//transform.Rotate( Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));

		rigidbody.AddRelativeTorque(Vector3.up * turn * Time.deltaTime);
		rigidbody.AddRelativeForce(forwardDirection * theThrust * Time.deltaTime);
	}
}
 */
// /*
using UnityEngine;
using System.Collections;

public class HoverRacing : MonoBehaviour 
{
	//  Approximate dimensions of the vehicle.
	public float length = 10;
	public float width = 5;
	public float height = 2;
	
	//  Height above planet surface to hover.
	public float hoverHeight = 4;
	
	//  Strength and persistence of the lifting force on the hover.
	public float springiness = 3;
	public float damping = .01f;
	
	//  Forward thrust parameter. Increase for a faster vehicle.
	public float thrust = 10;
	
	//  Alter y coordinate of Centre of Mass to increase hover's roll on
	//  turns.

	public Vector3 centreOfMass;
	
	//  The planet object...
	public Transform planet;
	
	//  ...and its gravity.
	public float gravity = 9.8f;
	
	// Use this for initialization
	void Start () {
		rigidbody.centerOfMass = centreOfMass;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//  Gravity toward the "planet".
		Vector3 gravForce = (planet.position - transform.position).normalized * gravity;
		rigidbody.AddForce(gravForce);
		
		//  Get the four corners of the vehicle in world space.
		Vector3 frontLeft = transform.TransformPoint(-width / 2, -height / 2, length / 2);
		Vector3 frontRight = transform.TransformPoint(width / 2, -height / 2, length / 2);
		Vector3 backLeft = transform.TransformPoint(-width / 2, -height / 2, -length / 2);
		Vector3 backRight = transform.TransformPoint(width / 2, -height / 2, -length / 2);
		
		//  Vehicle's relative "up" direction.
		Vector3 relUp = transform.TransformDirection(Vector3.up);
		RaycastHit frontLeftHit;
		RaycastHit frontRightHit;
		RaycastHit backLeftHit;
		RaycastHit backRightHit;
		
		//  Measure the distance to the ground with rays.
		Physics.Raycast(frontLeft, -relUp, out frontLeftHit);
		Physics.Raycast(frontRight, -relUp, out frontRightHit);
		Physics.Raycast(backLeft, -relUp, out backLeftHit);
		Physics.Raycast(backRight, -relUp, out backRightHit);
		
		//  Get the current velocity of the corner points in the
		//  hover's up/down direction to act as damping for the
		//  springy hovering force.
		Vector3 dampVec = new Vector3(0, damping, 0);
		
		Vector3 frontLeftDamp = transform.TransformDirection(
		Vector3.Scale(transform.InverseTransformDirection(rigidbody.GetPointVelocity(frontLeft)), dampVec));
		Vector3 frontRightDamp = transform.TransformDirection(Vector3.Scale(transform.InverseTransformDirection(rigidbody.GetPointVelocity(frontRight)), dampVec));
		Vector3 backLeftDamp = transform.TransformDirection(Vector3.Scale(transform.InverseTransformDirection(rigidbody.GetPointVelocity(backLeft)), dampVec));
		Vector3 backRightDamp = transform.TransformDirection(Vector3.Scale(transform.InverseTransformDirection(rigidbody.GetPointVelocity(backLeft)), dampVec));
		
		//  Calculate the lift given by each corner.
		Vector3 frontLeftLift = (-relUp * gravity / 4) + (relUp * (hoverHeight - frontLeftHit.distance) * springiness) - frontLeftDamp;
		Vector3 frontRightLift = (-relUp * gravity / 4) + (relUp * (hoverHeight - frontRightHit.distance) * springiness) - frontRightDamp;
		Vector3 backLeftLift = (-relUp * gravity / 4) + (relUp * (hoverHeight - backLeftHit.distance) * springiness) - backLeftDamp;
		Vector3 backRightLift = (-relUp * gravity / 4) + (relUp * (hoverHeight - backRightHit.distance) * springiness) - backRightDamp;
		
		//  Calculate a simple forward thrust from the arrow keys.
		float lThrust, rThrust;
		
		lThrust = rThrust = thrust * Input.GetAxis("Vertical");
		
		float horizAxis = Input.GetAxis("Horizontal");
		
		Vector3 lThrustForce = transform.TransformDirection(Vector3.forward) * (lThrust + horizAxis);
		Vector3 rThrustForce = transform.TransformDirection(Vector3.forward) * (rThrust - horizAxis);
		
		//  Add the forces to the hover at the appropriate places. Note that
		//  the back corners have forward thrust as well as lift.
		rigidbody.AddForceAtPosition(frontLeftLift, frontLeft);
		rigidbody.AddForceAtPosition(frontRightLift, frontRight);
		rigidbody.AddForceAtPosition(backLeftLift + lThrustForce, backLeft);
		rigidbody.AddForceAtPosition(backRightLift + rThrustForce, backRight);
		
	}
}
// */
