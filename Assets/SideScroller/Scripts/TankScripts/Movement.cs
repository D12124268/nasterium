using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float forwardRate =  3.0f;
	public float turnRate  = 2.0f;
	
	// Update is called once per frame
	void Update () {
	float forwardMoveAmount = Input.GetAxis("Vertical") * forwardRate;

	float turnForce = Input.GetAxis("Horizontal") * turnRate;

	transform.Rotate(0 , turnForce, 0 );

	transform.position +=  -transform.right * forwardMoveAmount * Time.deltaTime;
	}
}
