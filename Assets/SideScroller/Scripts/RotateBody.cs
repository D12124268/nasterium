using UnityEngine;
using System.Collections;

public class RotateBody : MonoBehaviour {

	Quaternion Sr;
	public Vector3 rotateLegnth = new Vector3();
	// Use this for initialization
	void Start () {
		Sr = transform.rotation;
	}
	public void resetRotate()
	{
		transform.rotation = Sr;
	}
	
	// Update is called once per frame
	void Update () {

		//Sr = transform.rotation;

		if(Input.GetKey(KeyCode.LeftArrow))
		{
			//rigidbody.AddForce(rotateLegnth,ForceMode.VelocityChange);
			
			gameObject.transform.Rotate(Vector3.right* Time.deltaTime);
			
			gameObject.transform.Rotate(Vector3.down , Space.World);

			
		}
		
		if(Input.GetKey(KeyCode.RightArrow))
		{
			//rigidbody.AddForce(-rotateLegnth,ForceMode.VelocityChange);
			
			gameObject.transform.Rotate(Vector3.left * Time.deltaTime);
			
			gameObject.transform.Rotate(Vector3.up , Space.World);
			

		}
		//transform.rotation = Quaternion.Slerp(transform.rotation, Sr, .5f* Time.deltaTime);
	}
}
