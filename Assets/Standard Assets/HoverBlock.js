#pragma strict

function Start () {

}
// You should change the center of this gameObject's mesh from default value (0,0,0).
// Because this script put its point to the contact point with the ground.
 
// And "use gravity" must be FALSE.
 
// Call HitTestWithRoad() from Update()
 
public var distance:float = 2.0;
public var smoothRatio:float = 0.2;
function HitTestWithRoad() {
var position:Vector3 = transform.position + transform.TransformDirection(Vector3.up) * 0.2;
var direction:Vector3 = transform.TransformDirection(Vector3.down);
var ray:Ray = new Ray(position, direction);
var hit:RaycastHit;
Debug.DrawLine(ray.origin, ray.origin + ray.direction * distance, Color.red);
var inGround:boolean = false;
if (Physics.Raycast(ray, hit, distance)) {
if (hit.collider.tag == 'road'){
inGround = true;
this.transform.position = hit.point;
Debug.DrawLine(hit.point, hit.point + hit.normal, Color.green);
var current:Vector3 = position - hit.point;
var target:Vector3 = hit.normal;
Debug.DrawLine(hit.point, hit.point + current.normalized, Color.white);
var targetQ:Quaternion;
//TODO: Using "velocity.normalize" instead of "Vector3(0, 1.0, 1.0)"
var fPosition:Vector3 = transform.position + transform.TransformDirection(Vector3(0, 1.0, 1.0));
var fDirection:Vector3 = transform.TransformDirection(Vector3.down);
var fRay:Ray = new Ray(fPosition, fDirection);
var fHit:RaycastHit;
var fDistance:float = 2;
Debug.DrawLine(fRay.origin, fRay.origin + fRay.direction * fDistance, Color.cyan);
if (Physics.Raycast(fRay, fHit, fDistance)) {
if (fHit.collider.tag == 'road'){
Debug.DrawLine(fHit.point, fHit.point + fHit.normal * fDistance, Color.magenta);
targetQ.SetLookRotation(fHit.point - transform.position, target);
}
}
if (targetQ == null) {
targetQ.SetLookRotation(transform.TransformDirection(Vector3.forward), target);
}
this.gameObject.transform.rotation = Quaternion.Slerp(this.gameObject.transform.rotation, targetQ, smoothRatio);
}
}
return inGround;
}
function Update () {
HitTestWithRoad();
}