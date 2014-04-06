using UnityEngine;
using System.Collections;

public class DestroyWhenHit : MonoBehaviour 
{

public Transform explosionPrefab;
	
    void OnCollisionEnter(Collision collision) 
	{
        
		//foreach (ContactPoint hit in collision.contacts) 
		//{
        //    Debug.DrawRay(hit.point, hit.normal, Color.white);
        //}
		
		
		ContactPoint contact = collision.contacts[0];
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;
        Instantiate(explosionPrefab, pos, rot);
        Destroy(gameObject);
    }
}