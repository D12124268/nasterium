/*
using UnityEngine;
using System.Collections;

public class TurretScript : MonoBehaviour {
	
	public GameObject myProjectile;
	public GameObject smoke;
	public float reloadTime = 1.0f;
	public float turnSpeed = 5.0f;
	public float firePauseTime = 0.2f;
	public float errorAmmount = 0.01f;
	public Transform myTarget;
	public Transform muzzlePositions;
	public Transform turretBall;
	
	private float nextFireTime = 5.0f;
	private float nextMoveTime = 0.2f;
	private float aimError = 0.01f;
	private Quaternion desiredRotation;
	
	void Start()
	{
		
	}
	void Update()
	{
		if (myTarget)
		{
			if (Time.time >= nextMoveTime)
			{
				CalculateAimPosition(myTarget.position);
				turretBall.rotation = Quaternion.Lerp(turretBall.rotation, desiredRotation, Time.deltaTime* turnSpeed);
			}
			if (Time.time >= nextFireTime)
			{
				FireProjectile();	
			}
		}
		
		
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Enemy")
		{
			nextFireTime = Time.time + (reloadTime * .5);
			myTarget = other.gameObject.transform;
		
		}
	}
	
	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.transform == myTarget)
		{
			myTarget = null;
		}
	}
				
	void CalculateAimPosition(Vector3 targetPos )
	{
		var aimPoint = Vector3(targetPos.x + aimError, targetPos.y + aimError, targetPos.z + aimError);
		desiredRotation = Quaternion.LookRotation(aimPoint)	;
	}
				
	void CalculateAimError()
	{
		aimError = Random.Range(-errorAmmount, errorAmmount);
	}
				
	void FireProjectile()
	{
		AudioClip.Play();
		nextFireTime = Time.time+ reloadTime;
		nextMoveTime = Time.time + firePauseTime;
		CalculateAimError();
					
		if (theMuzzlePos is muzzlePositions)
		{
			Instantiate(myProjectile, theMuzzle.position, theMuzzle.rotation);
			Instantiate(smoke, theMuzzle.position, theMuzzle.rotation);
		}
		
	}
}
*/