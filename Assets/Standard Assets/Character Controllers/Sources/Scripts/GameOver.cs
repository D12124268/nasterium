using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour 
{

	public Texture2D gameOverImage;
	
	void OnGUI()
	{
		GUI.DrawTexture(new Rect (0, 0, Screen.width, Screen.height), gameOverImage);
		//GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 200, 50), "Press Enter to Play Again");
	}
}
