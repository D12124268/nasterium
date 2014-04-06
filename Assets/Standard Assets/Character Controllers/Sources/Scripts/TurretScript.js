#pragma strict

//shoots the large EnemyTorpedo

public var bulletSpeed : float = 100;
public var bulletPrefab : Transform;
public var bulletSpawn : Transform;
var LookAtTarget : Transform;
var nextShotTime : float = 0.0;
var timeBetweenShots : float = 2.0;
var damp : float = 6.0;
var gunShot : AudioClip;
var health : int = 0;

var explosionPrefab : Transform;



function Update()
{
	
	if (LookAtTarget) 
	{
		var dist = Vector3.Distance(LookAtTarget.position, transform.position);
		//print ("Distance to Player: " + dist);
	}
	
	if(dist <= 10)      //LookAtTarget
		{
			var rotate = Quaternion.LookRotation(LookAtTarget.position - transform.position);
			transform.rotation = Quaternion.Slerp(transform.rotation, rotate, Time.deltaTime * damp);
			
			if (nextShotTime <= Time.time)
			{
				Shoot();
				nextShotTime = Time.time + timeBetweenShots;
			}
		}
		
	 if(health >= 10)
	 {
	 	gameObject.Find("GameManager").GetComponent("GameManager").SendMessage ("myKills");
	 	Destroy (gameObject, 0);
	 }	

}

function OnCollisionEnter(collision : Collision) 
{
//print hit collision objects for testing
for (var contact : ContactPoint in collision.contacts) 
		{
			//print(contact.thisCollider.name + " hit " + contact.otherCollider.name);
// Visualize the contact point
			//Debug.DrawRay(contact.point, contact.normal, Color.white);
		}

	var contact = collision.contacts[0];
    var rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
    var pos = contact.point;
	Instantiate(explosionPrefab, pos, rot);
	health += 1;
	//Destroy (gameObject, 0);
	
  
}



function Shoot()
{
	//var bullet = Instantiate(bulletPrefab, transform.Find("TurretBulletSpawn").position, transform.Find("TurretBulletSpawn").rotation);
	var bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
	bullet.rigidbody.AddForce(transform.forward * bulletSpeed);
	//audio.PlayOneShot(gunShot);

}
