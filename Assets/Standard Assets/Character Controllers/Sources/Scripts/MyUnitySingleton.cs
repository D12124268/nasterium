using UnityEngine;
using System.Collections;

public class MyUnitySingleton : MonoBehaviour 
{
 	public AudioClip mainMusic;
	//public GUIText referencetotext;
	
    private static MyUnitySingleton instance = null;
	
    public static MyUnitySingleton Instance 
	
	{
        get { return instance; }
    }
	
    void Awake() 
	{
        if (instance != null && instance != this) 
			{
	            Destroy(this.gameObject);
	            return;
	        } 
		else 
			{
	            instance = this;
	        }
        DontDestroyOnLoad(this.gameObject);
		audio.Play();
		audio.loop = true;
		
    }
	
	void Update()
	{
		
	}
	
	void OnGUI()
	{
		
			//referencetotext.text = "Total Kills: " + myKills;
		
		
	}
 
     // any other methods you need
}