using UnityEngine;
using System.Collections;

public class CarDriver : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if ( Input.GetKey ( KeyCode.W ) ) {
		transform.position += transform.forward * 5.0f * Time.deltaTime;	
		}

	if ( Input.GetKey ( KeyCode.A ) ) {
		transform.Rotate ( 0.0f,  -40.0f * Time.deltaTime, 0.0f );	
		}
		
	if ( Input.GetKey ( KeyCode.D ) ) {
		transform.Rotate ( 0.0f, 40.0f * Time.deltaTime, 0.0f  );	
		}

	if ( Input.GetKey ( KeyCode.S ) ) {
		transform.position -= transform.forward * 5.0f * Time.deltaTime;	
		}
		
	}
}
