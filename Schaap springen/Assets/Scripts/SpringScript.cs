using UnityEngine;
using System.Collections.Generic;


public class SpringScript : MonoBehaviour {

	public int sheepSpeed;
	public GameObject sheepPrefab;
	public float jumpHeight;
	public Vector3 jump;
	public Rigidbody rb;
	public Vector3 pos = new Vector3 ();
	public Vector3 lpos = new Vector3 ();
	public bool canJump = false;
	void Start () 
	{
		pos = transform.position;
	}
	

	void Update () 
	{
		Vector3 movement = new Vector3 ();
		movement.z = Time.deltaTime * sheepSpeed;
		transform.Translate (movement);

		Vector3 sheepPosition = new Vector3 ();

		// Schapen Springen
		if (pos.z >= Random.Range (-3.99f, -2.01f) && transform.position.z <= 0.5f) // NIET VERGETEN DAT HET SCHAAP AAN DE GROND MOET BLIJVEN
		{
			canJump = true;
			print( "Als ie nu niet springt....");
			lpos.y += 5.0f;
		}
		else
		{

		}
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
