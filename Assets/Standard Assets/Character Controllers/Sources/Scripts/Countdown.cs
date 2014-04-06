using System;

using System.Collections.Generic;

using UnityEngine;

 

public class Countdown : MonoBehaviour

{

    public float timeLeft = 10.0f;
	public Player BMGbool;
 		
	public void Start()
	{
		BMGbool = GameObject.Find("HornetPlayer").GetComponent<Player>();
	}

    public void Update()
    {

        if (timeLeft <= 0.0f)

        {
			BMGbool.BMG = false;
			timeLeft = 10.0f;
            guiText.text = "BMG InActive";

        }

        if (BMGbool.BMG == true)

        {
			
			timeLeft -= Time.deltaTime;
            guiText.text = "BMG Active: " + (int)timeLeft + " seconds";

        }
    }


}
