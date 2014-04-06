using UnityEngine;
using System.Collections;

public class rotateUpandDown : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0,0,1)* Input.GetAxis("Vertical")* 6);
		
		//float timer = 0f;
		
	}
}
