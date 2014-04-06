using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public bool BMG = false;
	public Component[] renderers;
	public Component[] scripts;
	
	// Use this for initialization
	void Start () 
	{
		if(!BMG)
		{
			renderers = GetComponentsInChildren<Renderer>();
				foreach (Renderer r in renderers) 
					{
					    if (r.CompareTag("BMG")) 
						{
					        r.enabled = false;					
			    		}
					}
		
		
			scripts = GetComponentsInChildren<MonoBehaviour>();
				foreach(MonoBehaviour s in scripts)
					{
						if (s.CompareTag("BMG"))
								{
					    			s.enabled = false;
								}
					}
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(BMG)
		{
			//renderers = GetComponentsInChildren<Renderer>();
				foreach (Renderer r in renderers) 
					{
					    if (r.CompareTag("BMG")) 
						{
					        r.enabled = true;					
			    		}
					}
		
		
			//scripts = GetComponentsInChildren<MonoBehaviour>();
				foreach(MonoBehaviour s in scripts)
					{
						if (s.CompareTag("BMG"))
								{
					    			s.enabled = true;
								}
					}
		}
		
		if(!BMG)
		{
			//renderers = GetComponentsInChildren<Renderer>();
				foreach (Renderer r in renderers) 
					{
					    if (r.CompareTag("BMG")) 
						{
					        r.enabled = false;					
			    		}
					}
		
		
			//scripts = GetComponentsInChildren<MonoBehaviour>();
				foreach(MonoBehaviour s in scripts)
					{
						if (s.CompareTag("BMG"))
								{
					    			s.enabled = false;
								}
					}
		}
	}
}
