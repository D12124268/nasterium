using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour 
{
	public static int score = 0;
	public GUIText scoreText;
	
	void OnGUI()
	{
		// newScore = score;

		//string scoreText = "Score: " + score;
		//GUI.Box (new Rect(Screen.width - 200,80,220,80),scoreText);
		//PlayerPrefs.SetInt("HighScore", newScore);
		//PlayerPrefs.SetInt ("Score", newScore);


		//scoreText.text = score;
		scoreText.text = score.ToString ("#");
		//distance.ToString("#");
	}
}