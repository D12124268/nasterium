using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour 
{

	public Texture2D startGameImage;
	
	void OnGUI()
	{
		GUI.DrawTexture(new Rect (0, 0, Screen.width, Screen.height), startGameImage);
		//GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 200, 50), "Press Enter to Play Again");
	}
}
