using UnityEngine;
using System.Collections;

public class MusicPlayerCode : MonoBehaviour {

	public AudioClip MusicToPlay;
	
	void Start()
	{
		audio.loop = true;
		audio.clip = MusicToPlay;
		audio.Play();
	}
}
