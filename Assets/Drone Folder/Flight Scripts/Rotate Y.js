#pragma strict
var speed : float = 1.0;
var rotateSpeed : float = 3.0;
 
    function Update() 
    {
    var controller : CharacterController = GetComponent(CharacterController);
    controller.transform.Rotate(0, Input.GetAxis ("Horizontal") * rotateSpeed, 0);
	}