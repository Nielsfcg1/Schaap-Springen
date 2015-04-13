using UnityEngine;
using System.Collections.Generic;

public class SpringScript : MonoBehaviour {

	public int sheepSpeed;
	public GameObject sheepPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
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
			{ Destroy(gameObject);
			print ("hit");
			}
		}

		//if(colliding.CompareTag("EndLevelCollider"))
		//{
		//	Destroy(GameObject);
		//}


	

}
