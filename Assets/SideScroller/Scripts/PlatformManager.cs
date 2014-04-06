using UnityEngine;
using System.Collections;
using System.Collections.Generic; //make lists

public class PlatformManager : MonoBehaviour {
	public int NumberPlatforms = 10; //number of platforms
	public List <PhysicMaterial> physMats = new List <PhysicMaterial>();
	public List <Material> regularMats = new List <Material>();

	public List <GameObject> platforms = new List <GameObject>();

	public Vector3 minScale = new Vector3(); //set scale varialbles
	public Vector3 maxScale = new Vector3();

	public Vector3 minHeight = new Vector3(); //set height varialbles
	public Vector3 maxHeight = new Vector3();

	public Vector3 minGap = new Vector3(); //set gap varialbles
	public Vector3 maxGap = new Vector3();

	public float roadCurve; //half the maxScale.z

	public float DistanceToRecycle; //when to replay the platformlist
	public GameObject runnerRef; // reference the player



	// Use this for initialization
	void Start () {

		runnerRef = GameObject.FindGameObjectWithTag("Player");

		//GameObject platformPrefab = Resources.Load("Prefabs/platform1") as GameObject;
		GameObject platformPrefab = Resources.Load("platform2") as GameObject; //call the platform from its folder

		//GameObject itemPrefab = Resources.Load("item") as GameObject;

		for(int i = 0; i < NumberPlatforms; i++) //run a loop through the number of platforms
		{

			GameObject g = Instantiate(platformPrefab,Vector3.zero,Quaternion.identity) as GameObject; //set platforms position

			//Vector3 tempScale = new Vector3(Random.Range(minScale.x,maxScale.x),1,1);
			Vector3 tempScale = new Vector3(Random.Range(minScale.x,maxScale.x),Random.Range(minScale.y,maxScale.y),Random.Range(minScale.z,maxScale.z));

			g.transform.localScale = tempScale;

			roadCurve = (minScale.z/2);

			Vector3 tempPos = new Vector3(); // make temp vectors so we can make a line of platforms
			if(platforms.Count > 0)
			{
				tempPos = platforms[platforms.Count -1].transform.position;
				tempPos.x += platforms[platforms.Count -1].transform.localScale.x*0.5f; //offset by half the scale

				tempPos.y += Random.Range(minHeight.y,maxHeight.y); //random height

				tempPos.x += g.transform.localScale.x*0.5f;

				tempPos.z += g.transform.localScale.z*0.05f;



			}

			tempPos.x += Random.Range(minGap.x,maxGap.x);

			g.transform.position = tempPos; //restet the new pos

			int index = Random.Range(0,physMats.Count);
			g.renderer.material = regularMats[index];
			g.collider.material = physMats[index];

			g.transform.parent = gameObject.transform; //make them a child
			platforms.Add(g);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(platforms[0].transform.position.x + DistanceToRecycle < runnerRef.transform.position.x)
		{
			GameObject g = platforms[0];
			platforms.Remove(g);

			int index = Random.Range(0,physMats.Count);
			g.renderer.material = regularMats[index];
			g.collider.material = physMats[index];
			
			g.transform.parent = gameObject.transform;


			Vector3 tempScale = new Vector3(Random.Range(minScale.x,maxScale.x),Random.Range(minScale.y,maxScale.y),Random.Range(minScale.z,maxScale.z));
			
			g.transform.localScale = tempScale;
			
			Vector3 tempPos = new Vector3(); // make temp vectors so we can make a line of platforms
			if(platforms.Count >0)
			{
				tempPos = platforms[platforms.Count -1].transform.position;
				tempPos.x += platforms[platforms.Count -1].transform.localScale.x*0.1f; //offset by half the scale
				
				tempPos.y += Random.Range(minHeight.y,maxHeight.y); //random height
				
				tempPos.x += g.transform.localScale.x*0.5f;


				//tempPos.z = (tempPos.z + roadCurve);
				//Debug.Log(tempPos.z); //test z pos
				if( (tempPos.z < - 400) || (tempPos.z > 400) )
				{
					roadCurve = roadCurve * -1;

				}
				if( (tempPos.z > - 400) || (tempPos.z < 400) )
				{

					tempPos.z = (tempPos.z +  Random.Range(0,roadCurve));
				}
				//if( platforms.Count <= 8 )
				//{
					
				//	Debug.Log("yelp");
				//}
			}
			
			//tempPos.x += Random.Range(minGap.x,maxGap.x);
			//

			tempPos.x += Random.Range(minGap.x,maxGap.x);

			g.transform.position = tempPos;

			platforms.Add(g);

			Item other; 
			other = g.GetComponent("Item") as Item; 
			other.PickUpCreate();


		}
	}
}
