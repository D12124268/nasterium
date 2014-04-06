#pragma strict

private var guiHealth : GameObject;
private var healthBarScript: GuiDisplayJava;



function Start()
{
	guiHealth = GameObject.Find("GameManager");
    healthBarScript = guiHealth.GetComponent(GuiDisplayJava) as GuiDisplayJava;
}

function OnTriggerEnter(other: Collider)
	{
	  	if (other.tag == "Player")
	  	{
	    	healthBarScript.healthWidth = healthBarScript.healthWidth + 20;
	    	Destroy(gameObject); // destroy self
	    }
  	}


    
    
