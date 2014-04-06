using UnityEngine;
using System.Collections;

public class AsteroidRotate : MonoBehaviour {

	void Start()
	{
		//var myTrans:Transform[]  = gameObject.GetComponentsInChildren.<Transform>() as Transform[];

		Transform[] myTrans = gameObject.GetComponentsInChildren<Transform>();

		foreach (Transform child in myTrans) 
		{
			child.position  += new Vector3 (Random.Range(-2,2),0.5f,Random.Range(-2,2));
			//child.rotation  += Quaternion.Euler (Random.Range(-0.5f,0.5f),Random.Range(-0.5f,0.5f),Random.Range(-0.5f,0.5f));
			//child.Rotate(Random.Range(1,5), Random.Range(1,5),Random.Range(1,5));
		}
		
	}
}

	