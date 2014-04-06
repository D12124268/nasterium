#pragma strict
var speed = 50.0;
function Update () 
{
var controller : CharacterController = GetComponent(CharacterController); 
 if (Input.GetKey(KeyCode.A))
    controller.transform.Rotate(Vector3.up * speed * Time.deltaTime);
 
 if (Input.GetKey(KeyCode.D))
    controller.transform.Rotate(-Vector3.up * speed * Time.deltaTime);
 
}