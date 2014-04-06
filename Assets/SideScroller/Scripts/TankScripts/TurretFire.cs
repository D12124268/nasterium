using UnityEngine;
using System.Collections;

public class TurretFire : MonoBehaviour {
	
	public float mySpeed  = 10;
	public float myRange = 10;
	private float myDist;

	
	// Update is called once per frame
	void Update () {
	transform.Translate(Vector3.forward * Time.deltaTime * mySpeed);
	myDist += Time.deltaTime * mySpeed;
	
		if ( mySpeed >= myRange )
		{
			Destroy( gameObject );
		}
	}
}