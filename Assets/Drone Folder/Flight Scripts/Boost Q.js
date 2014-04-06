#pragma strict

public var ConstantSpeedScript: ConstantSpeed;
private var IncSpeed : GameObject;

function Start() 
{
	//IncSpeed = GameObject.Find("HornetPlayer");
    //ConstantSpeedScript = IncSpeed.GetComponent(ConstantSpeed) as ConstantSpeed;
}




function Update() 
{
//var controller : CharacterController = GetComponent(CharacterController);	
	
	if (Input.GetKeyDown(KeyCode.Q))
	{
    
    	ConstantSpeedScript.moveSpeed = 40.0;
    }
}