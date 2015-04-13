using UnityEngine;
using System.Collections;

public class LevelController: MonoBehaviour {
	
	public int sheepSpeed;
	public float sheepSpawnChance;
	public GameObject sheepPrefab;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 sheepPosition = new Vector3();
		
		if(Random.value<sheepSpawnChance)
		{
			sheepPosition.x = 5.8f;
			sheepPosition.y = 2.0f;
			sheepPosition.z = -7.0f;
			Instantiate(sheepPrefab, sheepPosition, sheepPrefab.transform.rotation);
			
			if(sheepPosition.z >= 6.0f)
			{ 
				Destroy(gameObject);
			}
			
		}
		
		
		
	}
}
