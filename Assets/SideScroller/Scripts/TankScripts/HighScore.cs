using UnityEngine;
using System.Collections;

public class HighScore : MonoBehaviour {
public	TextMesh Hsc;

	// Use this for initialization
	void Start () {
	
	}
	void Awake()
	{
		Hsc.text = "HS:  " + PlayerPrefs.GetInt( "TankScore");
	}
	// Update is called once per frame
	void Update () {
	
	}
}
