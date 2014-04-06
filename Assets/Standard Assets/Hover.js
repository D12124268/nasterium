	var hoverHeight : float = 3;
    var hoverHeightStrictness : float = 1.0;
    var  forwardThrust : float = 5000.0;
    var  backwardThrust : float = 2500.0;
    var  bankAmount : float = 0.1;
    var  bankSpeed : float = 0.2;
    var  bankAxis : Vector3 = new Vector3(-1.0, 0.0, 0.0);
    var  turnSpeed : float = 2.0;
 
    var  forwardDirection : Vector3 = new Vector3(0.0, 0.0, 1.0);
 
    var  mass : float = 5.0;
    
    
    var playerControl : boolean = true;
 
    private var bank : float = 0.0;
 /*
    // positional drag
    var sqrdSpeedThresholdForDrag : float = 25.0;
    var superDrag : float = 2.0;
    var fastDrag : float = 0.5;
    var slowDrag : float = 0.01;
 
    // angular drag
    var sqrdAngularSpeedThresholdForDrag : float = 5.0;
    var superADrag : float = 32.0;
    var fastADrag : float = 16.0;
    var slowADrag : float = 0.1;
 */
 
 
 
	function SetPlayerControl(control : boolean)
    {
        playerControl = control;
    }
 
 
    function Start()
    {
        gameObject.rigidbody.mass = mass;
    }
 
    function FixedUpdate()
    {
    /*
        if (Mathf.Abs(thrust) > 0.01)
        {
            if (rigidbody.velocity.sqrMagnitude > sqrdSpeedThresholdForDrag)
                rigidbody.drag = fastDrag;
            else
                rigidbody.drag = slowDrag;
        }
        else
            rigidbody.drag = superDrag;
 
        if (Mathf.Abs(turn) > 0.01)
        {
            if (rigidbody.angularVelocity.sqrMagnitude > sqrdAngularSpeedThresholdForDrag)
                rigidbody.angularDrag = fastADrag;
            else
                rigidbody.angularDrag = slowADrag;
        }
        else
            rigidbody.angularDrag = superADrag;
      */
 
        transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, hoverHeight, transform.position.z), hoverHeightStrictness); //lerp back to hover hieght
 
        var amountToBank : float = rigidbody.angularVelocity.y * bankAmount;
 
        bank = Mathf.Lerp(bank, amountToBank, bankSpeed);
 
        var rotation : Vector3 = transform.rotation.eulerAngles;
        rotation *= Mathf.Deg2Rad;
        rotation.x = 0;
        rotation.z = 0;
        rotation += bankAxis * bank;
        rotation *= Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(rotation);
    }
 
    // thrust
    private var thrust : float = 0;
    private var turn : float = 0;
 
 	function Thrust( t : float )
    {
        thrust = Mathf.Clamp( t, -1.0, 1.0 );
    }
 
    function Turn(t : float)
    {
        turn = Mathf.Clamp( t, -1.0, 1.0 ) * turnSpeed; //look here
    }
 
    private var thrustGlowOn : boolean = false;
 
    function Update ()
    {
        var theThrust : float = thrust;
 
        if (playerControl)
        {
            thrust = Input.GetAxis("Vertical");
            turn = Input.GetAxis("Horizontal") * turnSpeed;
        }
 
        if (thrust > 0.0)
        {
            theThrust *= forwardThrust;
        }
        else
        {
            theThrust *= backwardThrust;
        }
 
        rigidbody.AddRelativeTorque(Vector3.up * turn * Time.deltaTime);
        rigidbody.AddRelativeForce(forwardDirection * theThrust * Time.deltaTime);
}