using UnityEngine;
using System.Collections;
[RequireComponent (typeof(AudioSource))]

public class Player2_movimiento : MonoBehaviour {

	private Rigidbody2D rb;
	public float velocid = 10f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();

	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.D)) {
			rb.velocity = new Vector2 (velocid, rb.velocity.y);

		} 

		if (Input.GetKeyUp (KeyCode.D)) {
			rb.velocity = new Vector2 (0, rb.velocity.y);


		} else if (Input.GetKey (KeyCode.A)) {
			rb.velocity = new Vector2 (-velocid, rb.velocity.y);


		} else if (Input.GetKeyUp (KeyCode.A)) {
			rb.velocity = new Vector2 (0, rb.velocity.y);
		
		}
	}
}

