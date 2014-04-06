using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Inventory : MonoBehaviour 
{
	public static List<string> PlayerInventory = new List<string>();
	public List<string> StartingItems = new List<string>();
	
	private int BoxHeight;
	
	void Start()
	{
		PlayerInventory.AddRange(StartingItems);	
	}
	
	void Update()
	{
		BoxHeight = 40 + ( PlayerInventory.Count * 20 );
	}
	
	void OnGUI()
	{
		GUI.Box(new Rect(0, 0, 110, BoxHeight), "");
		
		GUI.Label(new Rect( 5, 5, 100, 25), "Inventory");
		for( int i = 0; i < PlayerInventory.Count; i++ )
		{
			GUI.Label(new Rect( 5, 35 + (i * 20), 100, 25), PlayerInventory[i]);
		}
		
	}
}
