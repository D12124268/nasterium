using UnityEngine;
using System.Collections;

public class StoryPrompt : MonoBehaviour 
{
	
	static bool ShowStory = false;
	static string StoryBeat;
	
	public static void UpdateStory(string newStory)
	{
		StoryBeat = newStory;
		ShowStory = true;
	}
	
	public static void HideStory()
	{
		StoryBeat = "";
		ShowStory = false;
	}
	
	
	
	void OnGUI()
	{
		if( ShowStory )
			GUI.Box( new Rect( 20, Screen.height - 100, Screen.width - 40, 40 ), StoryBeat);	
	}
	
}
