var bullet : Rigidbody; 
var speed : float = 10.0f;
var muzzlePoint : Transform; 
 
function Update() {
    if(Input.GetButton("Fire1")) {
        var instance : Rigidbody = Instantiate(bullet, muzzlePoint.position, 
                                               muzzlePoint.rotation);
        instance.velocity = muzzlePoint.forward * speed;
    }
}