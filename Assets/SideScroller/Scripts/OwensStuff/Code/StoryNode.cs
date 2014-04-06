using UnityEngine;
using System.Collections;

public class StoryNode : MonoBehaviour {

	public string Story;
	
	void Start()
	{
		collider.isTrigger = true;	
	}
	
	void OnTriggerEnter( Collider WhatEnteredTheTrigger )
	{
		if( WhatEnteredTheTrigger.tag == "Player" )
		{
			StoryPrompt.UpdateStory( Story );
				
		}
	}
	
	void OnTriggerExit( Collider WhatExitedTheTrigger )
	{
		if( WhatExitedTheTrigger.tag == "Player" )
			StoryPrompt.HideStory();
	}
}
