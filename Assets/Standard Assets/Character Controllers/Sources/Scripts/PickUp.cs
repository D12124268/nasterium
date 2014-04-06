using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour 
{

	//public string WhatToAddToInventory = "PickUp Name";
	public AudioClip PickUpSound;
	public Player BMGbool;
	
	void Start()
		{
			collider.isTrigger = true;
			BMGbool = GameObject.Find("HornetPlayer").GetComponent<Player>();
		}
	
	void OnTriggerEnter(Collider other)
	{
		
		if (other.tag == "Player")
    	{
			PickedUp();
		}	
			
	}
	
	void PickedUp()
	{
		audio.PlayOneShot(PickUpSound);
		//Inventory.PlayerInventory.Add(WhatToAddToInventory);
		//HornetBMG.GetComponentsinChildren<Player>().BMG = true;
		
        BMGbool.BMG = true;
		
		Destroy(gameObject);
	}
	
}
