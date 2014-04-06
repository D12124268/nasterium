using UnityEngine;
using System.Collections;

public class Runner2 : MonoBehaviour {
	
	public float Speed = 0.0f;
	public bool IsOnGround = false;
	public float DeathHeight;
	
	public Vector3 jumpHeight = new Vector3();
	public Vector3 steerLegnth = new Vector3();
	
	public float rotateAmount; 
	public float rotateSpeed = 25.0f;
	Quaternion Sr;
	
	//gui
	Vector3 position;
	public float distance = 0.0f;
	public GUIText distanceText;
	Vector3 lastPosition;
	public float velocity;
	
	public Transform target;
	
	
	// Use this for initialization
	void Start () {
		Sr = transform.rotation;
		
		
	}
	
	// Update is called once per frame
	void Update () {
		rotateAmount = rotateSpeed * Time.deltaTime;
		
		//lastPosition = position;
		
		if(IsOnGround)
		{
			rigidbody.AddForce(new Vector3(Speed,0,0),ForceMode.Acceleration);
			
		}
		if(gameObject.transform.position.y< DeathHeight)
		{
			rigidbody.velocity = new Vector3();
			
			gameObject.transform.position = new Vector3(1,1,0); //place ship back OnCollisionExit track
			
			transform.rotation = Sr ;
			
			Destroy(GameObject.FindGameObjectWithTag("pManager"));
			GameObject.FindGameObjectWithTag("Manager").GetComponent<Manager>().Reset();
		}
		if(Input.GetButtonDown("Jump") && IsOnGround)
		{
			IsOnGround = false;
			rigidbody.AddForce(jumpHeight,ForceMode.VelocityChange);
		}
		
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			rigidbody.AddForce(steerLegnth,ForceMode.VelocityChange);

			 gameObject.transform.Rotate(Vector3.right* Time.deltaTime);
			
			gameObject.transform.Rotate(Vector3.down , Space.World);
			
			
		}
		
		if(Input.GetKey(KeyCode.RightArrow))
		{
			rigidbody.AddForce(-steerLegnth,ForceMode.VelocityChange);
			
			gameObject.transform.Rotate(Vector3.left* Time.deltaTime);
			
			gameObject.transform.Rotate(Vector3.up , Space.World);
			
			
		}
		transform.rotation = Quaternion.Slerp(transform.rotation, Sr, .5f* Time.deltaTime);
		
		
	}
	
	//distance += Vector3.Distance(position, lastPosition);
	//distanceText.text = distance.ToString("#");
	
	
	void OnCollisionEnter() {
		IsOnGround = true;
	}
	void OnCollisionStay() {
		IsOnGround = true;
	}
	void OnCollisionExit() {
		IsOnGround = false;
	}
}
