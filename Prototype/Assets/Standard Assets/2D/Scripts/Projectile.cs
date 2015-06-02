using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class Projectile : MonoBehaviour {

	public bool right;
	private float duration = 0.5f;
	private float speed  = 10;
	private PlatformerCharacter2D player;
	private Vector3 move = new Vector3(1,0,0);
	
	// Use this for initialization
	void Start () {
		Destroy (gameObject, duration);
	}
	
	// Update is called once per frame
	void Update () {
		if (right)
			transform.position += move * Time.deltaTime * speed;
		else 
			transform.position -= move * Time.deltaTime * speed;
	}	

	void OnTriggerEnter2D(Collider2D collision) {

		if (collision.gameObject.tag == "GravityChanger") {

			GravityBox gb = collision.GetComponent<GravityBox>();
			if(!gb.gravityChange) {
				gb.gravityChange = true;
				collision.gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 255, 0);
			}
			else {
				gb.gravityChange = false;
				collision.gameObject.GetComponent<SpriteRenderer>().color = new Color(10, 50, 10);
				gb.tonedeaf = false;
			}



			Destroy (gameObject);
		}
	}
}
