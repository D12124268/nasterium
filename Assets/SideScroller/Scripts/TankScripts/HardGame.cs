using UnityEngine;
using System.Collections;

public class HardGame : MonoBehaviour {

	void OnMouseEnter()
	{
		renderer.material.color = Color.blue;
		
	}
	
	void OnMouseExit()
	{
		renderer.material.color = Color.white;	
	}
		void OnMouseDown()
	{
		Application.LoadLevel("TankProject1");
	}
}
