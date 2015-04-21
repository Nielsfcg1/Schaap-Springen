using UnityEngine;
using System.Collections;

public class LevelController: MonoBehaviour {

	//Variabelen
	public int sheepSpeed;
	public float sheepSpawnChance;
	public GameObject sheepPrefab;
	public int clickCounter;
	public static int sheepDestroyCounter;
	public int spawnAmount;
	public int Spawned;
	public float levelDurationCounter;
	public float spawnDelay;
	public float spawnCounter;
	public int minRangeAmount;
	public int maxRangeAmount;
	public float minRangeDelay;
	public float maxRangeDelay;


	void Start () 
	{
		// Oorspronkelijke waarden
		spawnAmount = Random.Range ( minRangeAmount,maxRangeAmount);
		spawnDelay = Random.Range (minRangeDelay, maxRangeDelay);

		//print ("Er worden " + spawnAmount+ " schapen gespawnd" );
	}
	
	void Update () 
	{

		Vector3 sheepPosition = new Vector3();
		//print("spawned" + Spawned);

		//Debug.Log ("Counter" + spawnCounter);
		//Debug.Log ("Delay" + spawnDelay);


		if (levelDurationCounter >= 0.0f)
		{
			levelDurationCounter -= Time.deltaTime;
			//print (levelDurationCounter);
		}

		if (spawnCounter <= spawnDelay)
		{
			spawnCounter += Time.deltaTime;
		}
		else
		{
			spawnDelay = Random.Range (minRangeDelay, maxRangeDelay);
			spawnCounter = 0;
		}

		// Spawnen van een Schaap
		if (Spawned < spawnAmount && spawnCounter == 0.0f) 
		{
			sheepPosition.x = 5.8f;
			sheepPosition.z = -9f;
			Instantiate (sheepPrefab, sheepPosition, sheepPrefab.transform.rotation);
			Spawned++;
		}

		// Wat er gebeurd wanneer je klaar bent met je sessie
		if(spawnAmount == sheepDestroyCounter)
		{
			if (clickCounter >= (Spawned - (Spawned * 0.1)) && clickCounter <= (Spawned + (Spawned * 0.1)) )
			{
				//print(" You done it");
			}
			else
			{
				//print(" You stupid!");
			}
		}
		
		// Puntentelling
		if (Input.GetMouseButtonDown(0)) 
		{
			clickCounter++;
			//print ("Click" + clickCounter);
		}




	}
}
