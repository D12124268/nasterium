using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{
	public static int Kills = 0;  //static can be modified from any other script
	//public static int Lives = 3;
	public static bool gameOver = false;
	public static bool YouWin = false;
	
	//public static int Difficulty = 1;
	//public EnemyCreator enemyCreator;
	

		
	void Update()
	{
		if(gameOver == false && Input.GetKeyDown(KeyCode.Return))
		{
			StartGame();
		}
		
		if(gameOver && Input.GetKeyDown(KeyCode.Return))
		{
			ResetGame();
		}
		
			
		
	}
	
	public static void GameOver()
	{
		Application.LoadLevel("GameOver");
		gameOver = true;
	}
	
	public void StartGame()
	{
		Application.LoadLevel("Maze2");
		//Lives = 3;
		//Score = 0;
	}

	public void ResetGame()
	{
		Application.LoadLevel("Maze2");
		gameOver = false;
		//Lives = 3;
		//Score = 0;
	}
	
	public void myKills()
	{
		Kills += 1;
	}
	
}
