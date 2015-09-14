using UnityEngine;
using System.Collections;

public class characterControls : MonoBehaviour {
			
		public float speed = 5;
		private Rigidbody rb;
		
		void FixedUpdate () 
	
		{
			rb = GetComponent<Rigidbody> ();

			float moveHorizontal = Input.GetAxis ("Horizontal");
			float moveVertical = Input.GetAxis ("Vertical");

			Vector3 movement = new Vector3 (moveHorizontal, moveVertical, 0);

		if (moveHorizontal >= 6)
		{
			moveHorizontal = 6;
		}
		if (moveVertical >= 6)
		{
			moveVertical = 6;
		}

		rb.AddForce (movement * speed);
			
		}
	}

