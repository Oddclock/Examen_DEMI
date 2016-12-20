using UnityEngine;
using System.Collections;
[RequireComponent (typeof(AudioSource))]

public class Player1_movimiento : MonoBehaviour {

	private Rigidbody2D rb;
	public float velocid = 10f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();

	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey ("right")) {
			rb.velocity = new Vector2 (velocid, rb.velocity.y);

		} 

		if (Input.GetKeyUp ("right")) {
			rb.velocity = new Vector2 (0, rb.velocity.y);


		} else if (Input.GetKey ("left")) {
			rb.velocity = new Vector2 (-velocid, rb.velocity.y);


		} else if (Input.GetKeyUp ("left")) {
			rb.velocity = new Vector2 (0, rb.velocity.y);

		}
	}
}