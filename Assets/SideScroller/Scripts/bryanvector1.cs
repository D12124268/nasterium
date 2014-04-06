using UnityEngine;
using System.Collections;

public class bryanvector1 : MonoBehaviour {

	public GameObject ship;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	float speed = 10.0f;
		ship.transform.position += ship.transform.up * speed * Time.deltaTime;
	
	}
}
