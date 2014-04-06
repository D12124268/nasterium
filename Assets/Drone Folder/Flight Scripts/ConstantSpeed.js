#pragma strict
var moveSpeed = 5.0;
var moveDirection = Vector3.zero;

     function FixedUpdate() 
    {
       var controller : CharacterController = GetComponent(CharacterController);
        
          if(Input.GetButton("Jump"))
        {
          	//moveDirection = Vector3.right;
  			moveDirection *= moveSpeed; 
           ///transform.Translate( speed * Time.deltaTime, 0, 0);
            
            // Calculate the movement direction (forward motion)
 
  			var flags = controller.Move(moveDirection * Time.deltaTime);
  			
			
			moveDirection = transform.TransformDirection(Vector3.right);
        }
        //else
        //{
        	//transform.Translate( 0, 0, 0);
        
        //}
        
       
    }
    
    @script RequireComponent(CharacterController)