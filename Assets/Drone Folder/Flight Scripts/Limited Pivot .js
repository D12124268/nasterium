#pragma strict
function Update()
{
    var controller : CharacterController = GetComponent(CharacterController);
    var h = Input.GetAxis("Vertical"); // use the same axis that move back/forth
    var v = Input.GetAxis("Horizontal"); // use the same axis that turns left/right
    controller.transform.localEulerAngles.x =  -v*45; // forth/back banking first!
    controller.transform.localEulerAngles.z =   h*45;  // left/right
}