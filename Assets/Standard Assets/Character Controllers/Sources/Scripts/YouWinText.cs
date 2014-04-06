using UnityEngine;
using System.Collections;

public class YouWinText : MonoBehaviour 
{
	//public GameManager GMLink;
	
	
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(GameManager.YouWin == true)
		{
			guiText.text = "You Win!";
		}	
		
	}
}
