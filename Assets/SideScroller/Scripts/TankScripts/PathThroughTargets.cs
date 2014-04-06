using UnityEngine;
using System.Collections;

public class PathThroughTargets : MonoBehaviour
{
	public GameObject[] nextTarget;
	public float speed = 1.0f;
	public float goalSize = 0.1f;
	
	private int currentPathIndex = 0;
	private Vector3 movementDirection;
	
	void Start()
	{
		movementDirection = (nextTarget[currentPathIndex].transform.position - transform.position).normalized;	
	}
	
	// Update is called once per frame
	void Update ()
	{	
		//movement code
		transform.position += movementDirection*speed*Time.deltaTime;
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.name == nextTarget[currentPathIndex].name)
		{
			transform.position = nextTarget[currentPathIndex].transform.position;
			currentPathIndex++;
			movementDirection = (nextTarget[currentPathIndex].transform.position - transform.position).normalized;
		}
	}
}
