using UnityEngine;
using System.Collections;

public class StatusBar2 : MonoBehaviour {

	public int maxHealth = 100;
    static public int curHealth = 100;
    public float healthBarLength;
	public Texture2D bgImage;
	public GUISkin custom1;
	//static int adj;
     
    // Use this for initialization
    void Start () {
		healthBarLength = Screen.width / 4;
    }
     
    // Update is called once per frame
    void Update () {
		AdjCurrentHealth(0);
    }
	
    void OnGUI()
    {
	GUI.skin = custom1;
    //GUI.Box(new Rect(10, 10, healthBarLength, 20), "Health");
	GUI.Box(new Rect(10, 10, healthBarLength, 20), bgImage);
	}
	
	public void AdjCurrentHealth (int adj)
	{
	curHealth += adj;
		if(curHealth <= 0)
		{
			curHealth = 0;
		}
     if(curHealth >= maxHealth)
		{
			curHealth = maxHealth;
		}
	if(maxHealth < 1)
		{
			maxHealth = 1;
		}
	healthBarLength = ((Screen.width / 4) * (curHealth / (float)maxHealth));
    
	if(curHealth < 1)
	{
			Debug.Log("GameOver");
			PlayerPrefs.SetInt("YourScore", KeepingScore.Score);
			    if (KeepingScore.Score > PlayerPrefs.GetInt("TankScore"))
			{
				PlayerPrefs.SetInt("TankScore", KeepingScore.Score);
			}
         Application.LoadLevel("GameOver");
	}
	
	}
	
	
}

