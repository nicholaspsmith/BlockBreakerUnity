using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	private Paddle paddle;

	private bool hasStarted = false;
	private Vector3 paddleToBallVector;
	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle>();
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!hasStarted) {
			// Lock ball to paddle position
			this.transform.position = paddle.transform.position + paddleToBallVector;
		
			// Wait for mouse click to launch
			if (Input.GetMouseButtonDown (0)) {
				hasStarted = true;
				this.rigidbody2D.velocity = new Vector2 (2f, 8f);
			}
		}
	}
}
