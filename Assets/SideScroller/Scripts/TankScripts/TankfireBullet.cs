using UnityEngine;
using System.Collections;

public class TankfireBullet : MonoBehaviour {
	
	
	public GameObject projectile;
	public GameObject smoke;
	public float force = 40.0f;
	public TextMesh message;
	public AudioClip FireSound;
	// Update is called once per frame
	void Update () {
		if( force >= 80) // Ctrl button
		{
			force = 80 ;
			
		}
		message.text = "Power:  " +  force.ToString("f0");
		//message.text = "Force:" + force;
		if( Input.GetButton("Jump")) // Ctrl button
		{
			force += 80 * Time.deltaTime;
			
		}
		
		if( Input.GetButtonUp("Jump"))
		{
			GameObject pro = Instantiate (projectile,
				transform.position, Quaternion.identity)
				as GameObject;
			pro.AddComponent<Rigidbody>();
			pro.rigidbody.velocity = transform.right * force;
			force = 40;
			Instantiate(smoke, transform.position, transform.rotation);
			audio.PlayOneShot(FireSound);
			
		}
	}
}
