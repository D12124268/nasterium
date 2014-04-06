#pragma strict

var LookAtTarget : Transform;
var damp : float = 4.0;

function Start () 
{

}

function Update () 
{
	if(LookAtTarget)
		{
			var rotate = Quaternion.LookRotation(LookAtTarget.position - transform.position);
			transform.rotation = Quaternion.Slerp(transform.rotation, rotate, Time.deltaTime * damp);
			var forward : Vector3 = transform.TransformDirection(Vector3.forward) * 10;
			Debug.DrawRay(transform.position, forward, Color.green);
		}
}