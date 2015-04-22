using UnityEngine;
using System.Collections.Generic;


public class SpringScript : MonoBehaviour {

	public int sheepSpeed;
	public int jumpHeight;
	public bool isGrounded = false;
	public float jumpPosition;
	public Rigidbody rb;
	public bool canJump = true;
	void Start () 
	{
		jumpPosition = Random.Range (-3.99f, -2.01f);

	}
	

	void Update () 
	{
		Vector3 movement = new Vector3 ();
		movement.z = Time.deltaTime * sheepSpeed;
		transform.Translate (movement);

		// Schapen Springen
		if (transform.position.z >= jumpPosition && canJump) 
			{
			//print("spring kutschaap");
			jump ();
			}

	}
		void jump()
			{
				
				rb.AddForce(new Vector3 (0,jumpHeight,0),ForceMode.Force);
				canJump = false;
				print("void jump wordt uitgevoerd");
			}





	void OnTriggerEnter (Collider collider)
	{
		if( collider.tag == "EndGameCollider")
		{
	    LevelController.sheepDestroyCounter += 1;
		//print ("sheep" + LevelController.sheepDestroyCounter);
		Destroy(gameObject);

		}
	}

		
	/*void OnCollisionEnter (Collision Coll)
	{
		if (Coll.gameObject.tag == "Ground")
		{
			isGrounded = true;
		}
	}

	void OnCollisionExit (Collision Coll)
	{
		if (Coll.gameObject.tag == "Ground")
		{
			isGrounded = false;
		}
	}*/


	

}
