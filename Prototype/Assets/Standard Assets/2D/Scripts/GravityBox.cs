using UnityEngine;
using System.Collections;

public class GravityBox : MonoBehaviour
{
	private float speed = 4;
	public bool	gravityChange 	= false;
	public bool moveChange 		= false;

	//not effected by music
	public bool tonedeaf 		= false;
	Vector3 move = new Vector3(0, 1, 0);
	
	public Rigidbody2D rb;  

	public GravityBox ()
	{
	}

	void Start() {
		rb = GetComponent<Rigidbody2D> ();
	}

	void Update() {
		if (gravityChange && moveChange) {
			rb.Sleep();

			transform.position += move * Time.deltaTime * speed;
		}

		if (Input.GetKeyDown(KeyCode.R) && !tonedeaf) {
			moveChange = true;
		}
		
		if (Input.GetKeyDown (KeyCode.E) && !tonedeaf) {
			moveChange = false;
			rb.WakeUp();
		}
		
	}
}

