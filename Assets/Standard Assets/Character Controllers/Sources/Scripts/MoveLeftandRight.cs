using UnityEngine;
using System.Collections;

/*
public class MoveLeftandRight : MonoBehaviour {


}
 */

public class MoveLeftandRight : MonoBehaviour 
{
    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;
	public float power = 0.1f;
	
    void Update() 
	{
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
		
		//if(Input.GetButton("Jump"))
		//{
		//	power *= Time.deltaTime;
		//	transform.Translate(0,0,power);
		//	power++;
		//}
    }
	
		
		

}