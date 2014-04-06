using UnityEngine;
using System.Collections;

public class PlayerScore : MonoBehaviour {
public	TextMesh Sc;

	// Use this for initialization
	void Start () {
	
	}
	void Awake()
	{
		Sc.text = "Score:  " + PlayerPrefs.GetInt( "YourScore");
	}
	// Update is called once per frame
	void Update () {
	
	}
}
