using UnityEngine;
using System.Collections;

public class PlayerTrigger : MonoBehaviour {
	
	//public TextMesh message1;
	
	public GameObject explosion;
	//public GameObject target;
	
	public float lifetime = 3.0f;
	void OnTriggerEnter(Collider theEnterer)
	{
		if (theEnterer.tag == "EnemyBullet")
		{
			//StatusBar2 ph = (StatusBar2)GameObject.GetComponent("StatusBar2");
			//ph.AdjCurrentHealth(-10);
			StatusBar2.curHealth -= 5;
			
		if(KeepingScore.Score >= 150)
			{
				KeepingScore.Score -= 150;
			}
			if(KeepingScore.Score == 0)
			{
				KeepingScore.Score = 0;
			}
		Instantiate(explosion, transform.position, transform.rotation);
			
		Destroy( theEnterer );
		
		}
	}
}
