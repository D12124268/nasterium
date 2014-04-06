using UnityEngine;
using System.Collections;

public class KeepingScore : MonoBehaviour {
	public static int Score = 0;
	public TextMesh message1;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
		void Update () {
			//Debug.Log("score" + KeepingScore.Score);	
			message1.text = "Score: " + KeepingScore.Score;
			
		}
	
}
