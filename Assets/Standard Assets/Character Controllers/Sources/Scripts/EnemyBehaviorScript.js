#pragma strict

private var guiHealth : GameObject;
private var healthBarScript: GuiDisplayJava;

/*
Start is called only once in the lifetime of 
the behavior. So, it's a good place to initialize 
things only once.
*/
function Start() 
{
	
	guiHealth = GameObject.Find("GameManager");
    healthBarScript = guiHealth.GetComponent(GuiDisplayJava) as GuiDisplayJava;
    
    // Set initial value of the health...
    
    // Uncomment the line below and call reduceHealth() in the Update() method to watch health decrease
    healthBarScript.healthWidth = 199;
    
    // Uncomment the line below and call increaseHealth() in the Update() method to watch health increase
    // healthBarScript.healthWidth = -8;
    
}


function Update() 
{
     
   	reduceHealth();
   	
   	//increaseHealth();
   	
}

/*
Only decrease the health bar if it's greater than the min width it should ever be;
because we do not want it decreased beyond the left of its frame.
*/
function reduceHealth() 
{
   if(healthBarScript.healthWidth > -8) 
   {
       healthBarScript.healthWidth = healthBarScript.healthWidth - 1;
   }   
}

/*
Only increase the health bar if it's less than the max width it should ever be;
because we do not want it stretched out beyond its frame.
*/
function increaseHealth() 
{
   if(healthBarScript.healthWidth < 199) 
	   {
	       healthBarScript.healthWidth = healthBarScript.healthWidth + 1;
	   }
}
