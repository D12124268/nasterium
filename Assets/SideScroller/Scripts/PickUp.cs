using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {
	
	//public string WhatToAddToInventory = "PickUp Name";
	//public AudioClip PickUpSound;
	public float CountdownTime = 0;
	//public float AddTime = 10.0f;
	
	void Start()
	{
		collider.isTrigger = true;
	}
	
	void OnTriggerEnter( Collider WhatEnteredTheTrigger )
	{
		if( WhatEnteredTheTrigger.tag == "Player" )
		{
			PickedUp(WhatEnteredTheTrigger.gameObject);	
		}
	}
	
	void PickedUp(GameObject Player)
	{
		//audio.PlayOneShot(PickUpSound);
		//Inventory.PlayerInventory.Add(WhatToAddToInventory);
		//Score.score += 100;
		renderer.enabled = false;
		collider.enabled = false;
		Score.score += 100;

		//GameObject.Find ("TimerText").guiText.text =  Minutes.ToString ("f0") + ":" + Seconds.ToString("f0");
		//GameObject.Find ("TimerText").guiText.text = ":" + Seconds.ToString("f0"+10f);
		//CountdownTime.CountdownTime +=10;
	}
	
}