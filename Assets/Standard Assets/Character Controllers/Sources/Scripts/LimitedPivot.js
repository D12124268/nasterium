#pragma strict 
function Update() 
{ 
	//var controller : CharacterController = GetComponent(CharacterController); 
		var h = Input.GetAxis("Vertical"); // use the same axis that move back/forth 
		var v = Input.GetAxis("Horizontal"); // use the same axis that turns left/right 

		transform.localEulerAngles.x = -v*30; // forth/back banking first! 
		transform.localEulerAngles.z = h*30; // left/right 
}