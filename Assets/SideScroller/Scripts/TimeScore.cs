using UnityEngine;
using System.Collections;

public class TimeScore : MonoBehaviour
{
	public float CurrentTime = 0.0f;
	public float AddTime = 10.0f;
	
	void OnGUI()
	{
		
		CurrentTime = CurrentTime + AddTime;
	}
}

