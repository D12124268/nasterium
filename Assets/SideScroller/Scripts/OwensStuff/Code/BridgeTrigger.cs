using UnityEngine;
using System.Collections;

public class BridgeTrigger : MonoBehaviour {
	
	
	public string WhatThePlayerNeeds = "Item";
	public string MessageIfNoItem = "You need an item";
	
	// Use this for initialization
	void Start () 
	{
		collider.isTrigger = true;
	}
	
	void OnTriggerEnter( Collider WhatEnteredTheTrigger )
	{
		if( WhatEnteredTheTrigger.tag == "Player" )
		{
			if( Inventory.PlayerInventory.Contains( WhatThePlayerNeeds ) )
				BroadcastMessage("DropBridge");
			else
				StoryPrompt.UpdateStory( MessageIfNoItem );
				
		}
	}
	
	void OnTriggerExit( Collider WhatExitedTheTrigger )
	{
		if( WhatExitedTheTrigger.tag == "Player" )
			StoryPrompt.HideStory();
	}
}
