using UnityEngine;
using System.Collections.Generic;

public class SpringScript : MonoBehaviour {

	public int sheepSpeed;
	public GameObject sheepPrefab;
	 


	void Start () 
	{
	}
	

	void Update () 
	{
		Vector3 movement = new Vector3 ();
		movement.z = Time.deltaTime * sheepSpeed;
		transform.Translate (movement);

		Vector3 sheepPosition = new Vector3 ();
	}

		void OnTriggerEnter (Collider collider)
		{
			if( collider.tag == "EndGameCollider")
			{
		    LevelController.sheepDestroyCounter += 1;
			print ("sheep" + LevelController.sheepDestroyCounter);
			Destroy(gameObject);

			}
		}

		//if(colliding.CompareTag("EndLevelCollider"))
		//{
		//	Destroy(GameObject);
		//}


	

}
