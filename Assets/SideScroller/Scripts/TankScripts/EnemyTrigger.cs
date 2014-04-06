using UnityEngine;
using System.Collections;

public class EnemyTrigger : MonoBehaviour {
	
	//public TextMesh message1;
	
	public GameObject explosion;
	
	public float lifetime = 3.0f;
	void OnTriggerEnter(Collider theEnterer)
	{
		if (theEnterer.tag == "Bullet")
		{
		
		KeepingScore.Score += 1050;
			
		Instantiate(explosion, transform.position, transform.rotation);
		Destroy( theEnterer );
		Destroy(gameObject, lifetime);
		
		}
	}
}
