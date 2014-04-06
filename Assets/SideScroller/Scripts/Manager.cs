using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {
	public GameObject PlatformManager;
	// Use this for initialization
	void Start () {
		Reset();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Reset()
	{
		GameObject g = Instantiate(PlatformManager,Vector3.zero,Quaternion.identity) as GameObject;
	}
}
