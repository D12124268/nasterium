using UnityEngine;
using System.Collections;

public class NavigateToObject : MonoBehaviour {
	
	public Transform thePlayer;
		
	NavMeshAgent  nma;
	
	
	void Start () {
	nma = gameObject.GetComponent<NavMeshAgent>();
		
	nma.destination = thePlayer.position;
	InvokeRepeating("FindPlayer", 1.1f, 1.1f);
	}
	
	void FindPlayer () {
	 nma.destination = thePlayer.position;
	}
}
