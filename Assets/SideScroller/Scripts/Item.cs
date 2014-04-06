using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Item : MonoBehaviour {

	//public GameObject newItem;
	//bool disp = false;
	Vector3 PickUpMove = new Vector3 (0,10,0); 
	public List<GameObject> pickUpList = new List<GameObject>();
	// Use this for initialization
	void Start () {
		//GameObject Item = Instantiate(newItem,transform.position,newItem.transform.rotation) as GameObject;
	}
	public void PickUpCreate () 
	{ int randomPick = Random.Range (1, 50); 
		if (randomPick <= 5) 
		{ int prefabIndex = UnityEngine.Random.Range (0, 1); //randomly choose from pickUpList 
			GameObject pickUp = (GameObject)Instantiate (pickUpList [prefabIndex],transform.position,transform.rotation); 
			//in Start so it only happens once per platform on creation 
			pickUp.transform.position += PickUpMove; 
		} 
	}



	// Update is called once per frame
	
		void Update () {
		/*int p = Random.Range(0,2000);
		if(p == 2)
		{
		 disp = true;
			if(disp = true){
				Debug.Log("adhj");
				GameObject Item = Instantiate(newItem,transform.position,newItem.transform.rotation) as GameObject;
				disp = false;
			}
		} */
	}
}
