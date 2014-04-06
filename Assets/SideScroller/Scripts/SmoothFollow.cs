using UnityEngine;
using System.Collections;

public class SmoothFollow : MonoBehaviour {
	public Transform target;
	public float distance = 0.0f;
	public float height = 0.0f;
	public float damping;
	public bool smoothRotation = true;
	public float rotationDamping = 10.0f;
	
	void Update () {


		Vector3 wantedPosition = target.TransformPoint(0, height, -distance);
		//Vector3 wantedPosition = target.TransformPoint(-distance, height, 0);
		//transform.position = Vector3.Lerp (transform.position, wantedPosition, Time.deltaTime * damping);
		transform.position = Vector3.Lerp (transform.position, wantedPosition,  damping);

		transform.LookAt(target);
		/*
		if (smoothRotation) {
			Quaternion wantedRotation = Quaternion.LookRotation(target.position - transform.position, target.up);

			transform.rotation = Quaternion.Slerp (transform.rotation, wantedRotation, Time.deltaTime * rotationDamping);
		}
		
		else transform.LookAt (target, target.up);
		*/
	}
}