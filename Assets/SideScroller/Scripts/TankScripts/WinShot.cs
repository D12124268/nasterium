using UnityEngine;
using System.Collections;

public class WinShot : MonoBehaviour {

	//public TextMesh message1;
	
	public GameObject explosion;
	
	public float lifetime = 3.0f;
	void OnTriggerEnter(Collider theEnterer)
	{
		if (theEnterer.tag == "Bullet")
		{
		
		KeepingScore.Score += 5050;
			
		Instantiate(explosion, transform.position, transform.rotation);
		Destroy( theEnterer );
		Destroy(gameObject, lifetime);
	    Debug.Log("GameOver");
			PlayerPrefs.SetInt("YourScore", KeepingScore.Score);
			    if (KeepingScore.Score > PlayerPrefs.GetInt("TankScore"))
			{
				PlayerPrefs.SetInt("TankScore", KeepingScore.Score);
			}
         Application.LoadLevel("GameOver");
		
		}
	}
}