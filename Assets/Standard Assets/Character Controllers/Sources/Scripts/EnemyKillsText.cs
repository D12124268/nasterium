using UnityEngine;
using System.Collections;

public class EnemyKillsText : MonoBehaviour 
{
	public GameManager GMLink;
	public int myKills;
	
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		myKills = GameManager.Kills;
		guiText.text = "Enemies Destroyed:  " + myKills;
	}
}
