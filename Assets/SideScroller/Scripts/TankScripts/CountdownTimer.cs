using UnityEngine;
using System.Collections;

public class CountdownTimer : MonoBehaviour {

	public float Seconds = 59.0f;
	public TextMesh Message3;
	
	void Update () {
		if (Seconds > 0)
		{
		Seconds -= Time.deltaTime;
		}
		if ( Seconds <= 0)
		{	
			Debug.Log("GameOver");
			/*PlayerPrefs.SetInt("YourScore", KeepingScore.Score);
			if (KeepingScore.Score > PlayerPrefs.GetInt("TankScore"))
			{
				PlayerPrefs.SetInt("TankScore", KeepingScore.Score);
			}
            	   Application.LoadLevel("GameOver");
			*/
		}
		Message3.text = "Timer:  " +  Seconds.ToString("f0");
	}
}
