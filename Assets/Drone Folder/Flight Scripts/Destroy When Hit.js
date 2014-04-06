#pragma strict

private var guiHealth : GameObject;
private var healthBarScript: GuiDisplayJava;

var explosionPrefab : Transform;
var EnemyTorpedo : Transform;

public var gameOver : GameManager; //c# script

function Start() 
{
	
	guiHealth = GameObject.Find("GameManager");
    healthBarScript = guiHealth.GetComponent(GuiDisplayJava) as GuiDisplayJava;
    
    gameOver = gameObject.GetComponent(GameManager); //get the c#script
    // Set initial value of the health...
    
    // Uncomment the line below and call reduceHealth() in the Update() method to watch health decrease
    //healthBarScript.healthWidth = 199;
    
    // Uncomment the line below and call increaseHealth() in the Update() method to watch health increase
    // healthBarScript.healthWidth = -8;
    
}

function Update()
{
	if(healthBarScript.healthWidth <=0)
	{
		gameOver.GameOver();
		Destroy(transform.parent.gameObject);
		
	}
	
	if(healthBarScript.healthWidth >=250)
	{
		healthBarScript.healthWidth = 250;
		
	}
	
	
}



function OnCollisionEnter(collision : Collision) 
{
//print hit collision objects for testing
for (var contact : ContactPoint in collision.contacts) 
		{
			print(contact.thisCollider.name + " hit " + contact.otherCollider.name);
// Visualize the contact point
			Debug.DrawRay(contact.point, contact.normal, Color.white);
			
			var rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
		    var pos = contact.point;
			Instantiate(explosionPrefab, pos, rot);
			healthBarScript.healthWidth = healthBarScript.healthWidth - 5;
			
			
			
		}

	//var contact = collision.contacts[0];
    
    
}