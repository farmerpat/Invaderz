using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private Rigidbody2D rb2d;
	public float speed = 4;
	private Vector2 move = new Vector2(0.0f, 0.0f);
	private float horizontalMove = 0.0f;

	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		horizontalMove = Input.GetAxis ("Horizontal");

	}

	void FixedUpdate () {
		// should this be horizontalMove.normalized so we only pay attention to speed,
		// and not magnitude of horizontalMove? probably.
		move.x = horizontalMove;
		rb2d.AddForce (move * speed);

	}
}
