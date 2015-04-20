using UnityEngine;
using System.Collections;

public class LevelController: MonoBehaviour {
	
	public int sheepSpeed;
	public float sheepSpawnChance;
	public GameObject sheepPrefab;
	public int clickCounter;
	public static int sheepCounter;
	public int spawnAmount;
	public int Spawned;
	public float levelDurationCounter = 15;


	void Start () 
	{
		spawnAmount = Random.Range ( 18,37);
		print ("er worden" + spawnAmount+ "Schapen gespawnd" );
	}
	
	void Update () 
	{
		Vector3 sheepPosition = new Vector3();
		print("spawned" + Spawned);

		if (levelDurationCounter >= 0.0f)
		{
			levelDurationCounter -= 1 * Time.deltaTime;
			print (levelDurationCounter);
		}

		//for(levelDurationCounter >= 0; i < numEnemies; i++)


		if (Spawned < spawnAmount && levelDurationCounter >= 0.0f) 
		{

			if (Random.value < sheepSpawnChance) 
			{
				sheepPosition.x = 5.8f;
				sheepPosition.y = 2.0f;
				sheepPosition.z = -7.0f;
				Instantiate (sheepPrefab, sheepPosition, sheepPrefab.transform.rotation);
				Spawned++;


			}
		}

		if (Input.GetMouseButtonDown(0)) 
		{
			clickCounter++;
			print ("Click" + clickCounter);
		}

	}
}
