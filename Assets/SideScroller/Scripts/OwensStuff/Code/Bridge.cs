using UnityEngine;
using System.Collections;

public class Bridge : MonoBehaviour {
	
	public float MoveSpeed = -1f; 
	public bool drop = false;
	
	public void DropBridge()
	{
		drop = true;	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(drop)
		{
			if( transform.eulerAngles.x > 0  && transform.eulerAngles.x < 300)
			{
				transform.Rotate( transform.right , MoveSpeed * Time.deltaTime);	
			}
		}
	}
}
