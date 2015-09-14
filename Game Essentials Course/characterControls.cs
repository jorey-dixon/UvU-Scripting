using UnityEngine;
using System.Collections;

public class characterControls : MonoBehaviour {
			
		public float speed = 5;
		public float reduceSpeed = -5;
		public float jumpSpeed = 2;

		private Rigidbody rb;
		
		void FixedUpdate () 
	
		{
			rb = GetComponent<Rigidbody> ();

			float moveHorizontal = Input.GetAxis ("Horizontal");
			float moveVertical = Input.GetAxis ("Vertical");
			//float Jump = Input.GetAxis ("Jump");
			Vector3 movement = new Vector3 (moveHorizontal, 0, 0);
			//Vector3 movement = new Vector3 (Input.GetAxis("moveHorizontal", 0, 0);

			Vector3 Jumping = new Vector3 (0, moveVertical, 0);
			//float totalforce = Jumping * jumpSpeed;

			rb.AddForce (movement * speed);
			

		//This lets it move left and right fairly ok with addforce.
		if (Input.GetKeyDown (KeyCode.LeftArrow)) 
		{
			if (moveHorizontal >= 2)
			{
				moveHorizontal = 2;
			}
		} 
		else 
		{
			moveHorizontal = 0;
		}

		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			if (moveHorizontal >= 2)
			{
				moveHorizontal = 2;
			}
			//rb.AddForce (movement * speed);
		}
		else 
		{
			moveHorizontal = 0;
		}

		// The next part is jump

		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			rb.AddForce (Jumping * jumpSpeed);

		} 
		else 
		{
			//This needs to reduce jumping slowly
		}
		



		//if (Input.GetKeyDown (KeyCode.LeftArrow)) 
		//    {
		//	rb.AddForce ( movement * reduceSpeed);
		//	}

		//if (Input.GetKeyDown (KeyCode.RightArrow)) 
		//    {
		//	rb.AddForce ( movement * speed);
		//	}
		//if (Input.GetKeyDown (KeyCode.Space)) 
		//{
		//	rb.AddForce ( Jumping * jumpSpeed);
		//}

			
		}
	}

