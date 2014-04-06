#pragma strict

//Shoots the small EnemyTorpedo

var LookAtTarget : Transform;
public var bulletSpawn : Transform;
var nextShotTime2 : float = 0.0;
var timeBetweenShots2 : float = 1.0;
var damp : float = 6.0;
var gunShot : AudioClip;

public var bulletSpeed2 : float = 200;
var Torpedo2 : Transform;
var explosionPrefab : Transform;

function Update()
{
	
	if (LookAtTarget) 
	{
		var dist = Vector3.Distance(LookAtTarget.position, transform.position);
		//print ("Distance to Player: " + dist);
	}
	
	if(dist <= 10)
		{
			var rotate = Quaternion.LookRotation(LookAtTarget.position - transform.position);
			transform.rotation = Quaternion.Slerp(transform.rotation, rotate, Time.deltaTime * damp);
			
			if (nextShotTime2 <= Time.time)
			{
				Shoot2();
				nextShotTime2 = Time.time + timeBetweenShots2;
			}
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
	Destroy (gameObject, 0);
	
  
}


function Shoot2()
{
	var bullet2 = Instantiate(Torpedo2, bulletSpawn.position, bulletSpawn.rotation);
	//var bullet2 = Instantiate(Torpedo2, transform.position, transform.rotation);
	bullet2.rigidbody.AddForce(transform.forward * bulletSpeed2);
	//audio.PlayOneShot(gunShot);

}