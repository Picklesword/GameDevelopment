using UnityEngine;
using System.Collections;

public class ChangeForce : MonoBehaviour {

	bool moveUp = false;

	Vector3 move = new Vector3(0, 1, 0);

	int speed = 4;

	public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (moveUp == true) {
			rb.Sleep ();
/*			if(gameObject.GetComponent<Rigidbody2D>() != null)
				Destroy(rb);
*/
			transform.position += move * Time.deltaTime * speed;
		}

		if (Input.GetKeyDown(KeyCode.R)) {
			moveUp = true;
		}

		if (Input.GetKeyDown (KeyCode.E)) {
			moveUp = false;
			rb.WakeUp();
			/*
			if(gameObject.GetComponent<Rigidbody2D>() == null)
			{
				rb = gameObject.AddComponent<Rigidbody2D> ();
				rb.fixedAngle = true;
				rb.mass = 30;
			}
			*/
		}
	}
}
