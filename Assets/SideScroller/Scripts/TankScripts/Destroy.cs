using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	public float life = 1.0f;

	void OnTriggerEnter(Collider theEnterer)
	{
		if (theEnterer.tag == "Player")
		{
			
			Debug.Log("Pickup");
		}
	}

	// Update is called once per frame
	void Update () {
	life -= Time.deltaTime;
		
		if (life <= 0.0)
		{
		Destroy(gameObject);	
		}
	}
}
