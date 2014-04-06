using UnityEngine;
using System.Collections;

public class EnemyShooter : MonoBehaviour {
	
	public GameObject bullet;
	public float bulletSpeed = 1.0f;
	public float fireRate = 1.0f;
	public float fireRadius = 5.0f;
	//public AudioClip FireSound;

	// Use this for initialization
	void Start ()
	{
		InvokeRepeating("SpawnBullet",fireRate,fireRate);
	}
			
	void SpawnBullet()
	{
		GameObject target = null;
		
		foreach(Collider col in Physics.OverlapSphere(transform.position, fireRadius))
		{
			if(col.tag == "Player")
			{
				target = col.gameObject;
				break;
			}
		}
		
		if(target != null) //fire rocket
		{
			GameObject newBullet = Instantiate(bullet,transform.position,bullet.transform.rotation) as GameObject;
			newBullet.rigidbody.AddForce((target.transform.position - transform.position).normalized*bulletSpeed,ForceMode.VelocityChange);
			//audio.PlayOneShot(FireSound);
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}