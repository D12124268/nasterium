using UnityEngine;
using System.Collections;

public class ShootBullets : MonoBehaviour 

{

//properties go here
	public Vector3 size = new Vector3(0.25f,0.25f,0.25f);
	public float Speed = 10;  //how fast the bullet moves
	public Rigidbody Projectile; //what he shoots, Note; must be set in Unity
	public Transform muzzlePoint; //location of object he shoots from...gun
	
	
	// Update is called once per frame
	void Update () 
	{
		if( Input.GetButtonDown("Fire1") )
		{
			Shoot ();
		}
	
	}
	
	void Shoot()
		
	{
		//creates projectiles
				
		Rigidbody pewpew; 
		pewpew = Instantiate(Projectile, muzzlePoint.position, muzzlePoint.rotation) as Rigidbody;
        pewpew.velocity = muzzlePoint.forward * Time.deltaTime * Speed;
		pewpew.transform.localScale = size;
	}
	

	
}
