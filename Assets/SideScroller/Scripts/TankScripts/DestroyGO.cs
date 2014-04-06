using UnityEngine;
using System.Collections;

public class DestroyGO : MonoBehaviour {
	
	public float lifetime;
	public GameObject explosion;
	
	void OnTriggerEnter(Collider theEnterer)
	{
		if (theEnterer.tag == "Bullet")
		{
			
		KeepingScore.Score += 5500;
		Debug.Log("score" + KeepingScore.Score);	
		
		Instantiate(explosion, transform.position, transform.rotation);
		Destroy(gameObject, lifetime);
		Debug.Log("HaHa");
		
		Destroy( theEnterer );
		Destroy(gameObject, lifetime);
		}
	}
}
